using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;

var filePath = Path.Combine("../../examples/example1.html");
var filePathActual = Path.GetFullPath(filePath);


using var stream = File.Open(filePathActual, FileMode.Open, FileAccess.Read);
using var reader = new StreamReader(stream);
var html = await reader.ReadToEndAsync();
reader.Close();
stream.Close();
html = $"<article>{html}</article>";
// html = "<p>Hello<span>World</span>!!</p>";

var htmlDocument = new HtmlDocument();
htmlDocument.LoadHtml(html);

var text = htmlDocument.DocumentNode.InnerText;
string innerText;
// var decodedText = HttpUtility.HtmlDecode(text);

// var innerText = Regex.Replace(decodedText, @"\s+", " ");



// Console.WriteLine(innerText);

// return;

List<string> texts = new();

GetInnerText(htmlDocument.DocumentNode, texts);

StringBuilder stringBuilder = new();
foreach (var t in texts)
{
    stringBuilder.AppendLine(t);
}
innerText = stringBuilder.ToString();
// innerText = Regex.Replace(innerText, @"\s+", " ");
Console.WriteLine(innerText);


void GetInnerText(HtmlNode node, List<string> buffer)
{
    // Console.Write("GetInnerText => {0} ", node.Name);

    if (node.HasChildNodes)
    {
        foreach (var childNode in node.ChildNodes)
        {
            if (childNode.Name.Equals("img", StringComparison.OrdinalIgnoreCase))
            {
                var ariaHidden = childNode.Attributes["aria-hidden"]?.Value ?? string.Empty;
                if (!ariaHidden.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    buffer.Add($"![{childNode.Attributes["alt"].Value}]({childNode.Attributes["src"].Value})");
                }
            }

            GetInnerText(childNode, buffer);
        }
    }
    else
    {
        var decodedText = HttpUtility.HtmlDecode(node.InnerText)?.Trim();
        if (!string.IsNullOrWhiteSpace(decodedText))
        {
            decodedText = Regex.Replace(decodedText, @"\s+", " ");

            // if (node.ParentNode.Name.Equals("li", StringComparison.InvariantCultureIgnoreCase))
            // {
            //     decodedText = $"- {decodedText}";
            // }

            buffer.Add(decodedText);
            // Console.WriteLine("node.ParentNode.Name={0}", node.ParentNode.Name);
            if (node.Name.Equals("p", StringComparison.InvariantCultureIgnoreCase))
            {
                buffer.Add(" ");
            }
        }
        // else
        // {
        //     Console.WriteLine("No #text");
        // }
    }

}