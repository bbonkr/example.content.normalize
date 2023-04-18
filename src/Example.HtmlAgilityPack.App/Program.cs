using System;
using System.Collections;
using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;

public class Program
{
    public static void Main()
    {
        var html = "<Html content here>";

        if (!html.StartsWith("<html>", StringComparison.OrdinalIgnoreCase))
        {
            html = $"<html><body>{html}</body></html>";
        }

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);
        var lineNum = 1;
        var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");


        DocumentListModel source = new();

        var tagsExpression = new Regex(@"<.*?>", RegexOptions.IgnoreCase | RegexOptions.Multiline);

        string temporaryText = string.Empty;

        foreach (var node in htmlBody.ChildNodes)
        {
            if (node.NodeType != HtmlNodeType.Element) { continue; }

            var textOnly = tagsExpression
            .Replace(node.InnerHtml, string.Empty)
            .Replace("&nbsp;", " ")
            .Replace("\\n", Environment.NewLine)
            .Trim()
            ;

            textOnly = HttpUtility.HtmlDecode(textOnly);


            if (string.IsNullOrWhiteSpace(textOnly)) { continue; }

            TextModel element = new()
            {
                ElementName = node.Name.ToLower(),
                Text = textOnly,
                Index = lineNum,
            };

            source.Add(element);

            lineNum++;
        }

        var readonlySource = source.List
            .OrderBy(x => x.Index)
            .ToImmutableList();

        List<TextModel> temporaryList = new();

        foreach (var item in readonlySource)
        {
            if (item.ElementName.StartsWith("h", StringComparison.OrdinalIgnoreCase))
            {
                temporaryList.Add(item);
                continue;
            }

            if (item.Next != null && new[] { "ul", "ol" }.Contains(item.Next.ElementName))
            {
                temporaryList.Add(item);
                continue;
            }

            if (temporaryList.Any())
            {
                StringBuilder builder = new();
                foreach (var tempItem in temporaryList)
                {
                    builder.AppendLine(tempItem.Text);
                }

                item.Text = $"{builder.ToString()}{item.Text}";

                source.Merge(temporaryList.Select(x => x.Index).Append(item.Index), item);

                temporaryList.Clear();
            }
        }

        source.NormalizeIndex();

        foreach (var element in source.List.OrderBy(x => x.Index))
        {
            WriteLine(element);
        }

        WriteLine("-".PadLeft(80, '-'));

        var longTextItems = source.List.Where(x => x.Text.Length > DocumentListModel.MAX_TEXT_LENGHT).ToArray();
        if (longTextItems.Any())
        {
            foreach (var element in longTextItems)
            {
                WriteLine(element);
            }
        }
        else
        {
            WriteLine($"There is no item of over {DocumentListModel.MAX_TEXT_LENGHT:n0}");
        }

    }

    private static void WriteLine(TextModel model)
    {
        Console.WriteLine($"[{model.Index}]\t[{model.ElementName}] L={model.Text.Length:n0}: {model.Text}");
    }

    private static void WriteLine(string text)
    {
        Console.WriteLine(text);
    }
}

public class TextModel
{

    public string ElementName { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    public double Index { get; set; }

    public TextModel? Previous { get; private set; }

    public TextModel? Next { get; private set; }

    public void SetPrevious(TextModel? previous) => Previous = previous;

    public void SetNext(TextModel? next) => Next = next;
}

public class DocumentListModel
{
    public const int MAX_TEXT_LENGHT = 1_000;

    private readonly List<TextModel> list;

    public DocumentListModel()
    {
        list = new();
    }

    public void Add(TextModel item)
    {
        Add(item, false);
    }

    protected void Add(TextModel item, bool ignoreMaxTextLength = false)
    {
        var lastItem = list
            .Where(x => x.Index < item.Index)
            .OrderBy(x => x.Index)
            .LastOrDefault();

        if (lastItem != null)
        {
            lastItem.SetNext(item);

            item.SetPrevious(lastItem);
            item.SetNext(lastItem.Next);

            lastItem.Next?.SetPrevious(item);
        }

        if (!ignoreMaxTextLength && item.Text.Length > MAX_TEXT_LENGHT)
        {
            var increasement = 0.001;
            foreach (var line in item.Text.Split(Environment.NewLine))
            {
                TextModel chunk = new()
                {
                    Index = item.Index + increasement,
                    ElementName = item.ElementName,
                    Text = line,
                };

                Add(chunk, true);

                increasement += increasement;
            }
        }
        else
        {
            list.Add(item);
        }

    }

    public void Merge(IEnumerable<double> indexes, TextModel item)
    {
        var first = indexes.First();
        var firstItem = list.Where(x => x.Index == first).FirstOrDefault();
        int firstItemIndex;

        if (firstItem == null)
        {
            throw new Exception($"entry not found. (index = {first})");
        }
        else
        {
            firstItemIndex = list.IndexOf(firstItem);
        }

        var removeCandidates = list.FindAll(x => indexes.Contains(x.Index));

        if (removeCandidates != null && removeCandidates.Any())
        {
            foreach (var removeItem in removeCandidates)
            {
                removeItem.Next?.SetPrevious(null);
                removeItem.Previous?.SetNext(null);

                list.Remove(removeItem);
            }
        }

        Add(item);
    }

    public void NormalizeIndex()
    {
        var index = 0;
        foreach (var item in list.OrderBy(x => x.Index))
        {
            item.Index = index;
            index++;
        }
    }

    public TextModel? Get(double index)
    {
        return list.Where(x => x.Index == index).FirstOrDefault();
    }

    public IEnumerable<TextModel> List { get => list; }
}