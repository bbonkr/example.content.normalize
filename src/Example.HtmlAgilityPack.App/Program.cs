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
        var html = "<h2>Introduction</h2>\n<p><img style=\"display: block; margin - left: auto; margin - right: auto;\" src=\"https://chblob.icloudhospital.com/thumbnails/hypertension-867855_1920-edccb07d-210d-4a9b-b7a2-664e2fdec335.webp\" alt=\"blood pressure \" width=\"743\" height=\"495\" /></p>\n<p>Maintaining optimal blood pressure is a cornerstone of cardiovascular health, playing a pivotal role in preventing various medical conditions. \"A Guide to Comprehensive Blood Pressure Management\" is a holistic exploration of strategies, lifestyle modifications, and medical interventions aimed at achieving and sustaining healthy blood pressure levels. This comprehensive guide aims to empower individuals to take proactive steps towards cardiovascular well-being.</p>\n<p>&nbsp;</p>\n<h2>Understanding Blood Pressure</h2>\n<p><strong>1. Definition and Measurement:</strong></p>\n<p>At its core, blood pressure represents the force exerted by blood against the walls of arteries as the heart diligently pumps it throughout the body. This fundamental physiological parameter is quantified in millimeters of mercury (mmHg), presenting itself as a dual numerical expression &ndash; systolic pressure over diastolic pressure.</p>\n<ul>\n<li><strong>Systolic Pressure (During Heartbeats):</strong></li>\n</ul>\n<p>The first number in the blood pressure reading reflects systolic pressure. This signifies the force exerted by blood against arterial walls when the heart contracts and pumps blood into the circulatory system.</p>\n<ul>\n<li><strong>Diastolic Pressure (Between Heartbeats):</strong></li>\n</ul>\n<p>Conversely, the second number denotes diastolic pressure, representing the force when the heart relaxes between beats, allowing blood to fill the chambers and prepare for the next cycle.</p>\n<p>&nbsp;</p>\n<p><strong>2. Normal and Abnormal Ranges:</strong></p>\n<p>Understanding the spectrum of blood pressure values is crucial for gauging cardiovascular health and identifying potential concerns.</p>\n<ul>\n<li><strong>Normal Blood Pressure (120/80 mmHg):</strong></li>\n</ul>\n<p>The benchmark for optimal blood pressure is conventionally set at 120/80 mmHg. This represents the ideal balance, ensuring efficient blood circulation without undue strain on arterial walls.</p>\n<ul>\n<li><strong>Hypertension (Consistently Exceeding 130/80 mmHg):</strong></li>\n</ul>\n<p>Hypertension, or high blood pressure, is diagnosed when readings consistently surpass the 130/80 mmHg threshold. This condition places increased stress on the cardiovascular system and is a significant risk factor for heart disease and other complications.</p>\n<ul>\n<li><strong>Hypotension (Low Blood Pressure):</strong></li>\n</ul>\n<p>On the contrary, hypotension refers to abnormally low blood pressure. While there isn't a specific numerical definition, it becomes a concern when it leads to symptoms such as dizziness, fainting, or inadequate blood flow to vital organs.</p>\n<p>These numerical benchmarks serve as vital indicators, guiding healthcare professionals in assessing cardiovascular health and formulating appropriate interventions. Regular monitoring and understanding of these ranges empower individuals to actively engage in their well-being, fostering a proactive approach to cardiovascular health management.</p>\n<h2>&nbsp;</h2>\n<h2>Comprehensive Lifestyle Modifications</h2>\n<p><img style=\"display: block; margin-left: auto; margin-right: auto;\" src=\"https://chblob.icloudhospital.com/thumbnails/wp1873138%20%281%29-3e353232-e43d-44ab-9e47-371ed2a9299c.webp\" alt=\"Regular Physical Activity\" width=\"880\" height=\"495\" /></p>\n<ol>\n<li>\n<p><strong>Healthy Diet:</strong></p>\n<ul>\n<li>Adopting a heart-healthy diet rich in fruits, vegetables, whole grains, lean proteins, and low-fat dairy products can contribute to blood pressure management. The Dietary Approaches to Stop Hypertension (DASH) diet is specifically designed for this purpose.</li>\n</ul>\n</li>\n<li>\n<p><strong>Regular Physical Activity:</strong></p>\n<ul>\n<li>Engaging in regular physical activity, such as brisk walking, swimming, or cycling, helps lower blood pressure, improves cardiovascular health, and contributes to overall well-being.</li>\n</ul>\n</li>\n<li>\n<p><strong>Weight Management:</strong></p>\n<ul>\n<li>Maintaining a healthy weight is crucial for blood pressure management. Weight loss, even modest, can have a significant impact on reducing hypertension risk.</li>\n</ul>\n</li>\n<li>\n<p><strong>Limiting Sodium Intake:</strong></p>\n<ul>\n<li>Reducing sodium (salt) intake is vital for controlling blood pressure. Limiting processed foods, avoiding excessive salt use, and choosing low-sodium alternatives are effective strategies.</li>\n</ul>\n</li>\n<li>\n<p><strong>Moderating Alcohol Consumption:</strong></p>\n<ul>\n<li>Moderate alcohol consumption is generally considered acceptable, but excessive intake can lead to hypertension. Limiting alcohol intake contributes to overall cardiovascular health.</li>\n</ul>\n</li>\n</ol>\n<p>&nbsp;</p>\n<h2>Medical Interventions</h2>\n<p><img style=\"display: block; margin-left: auto; margin-right: auto;\" src=\"https://chblob.icloudhospital.com/thumbnails/healthy-blood-pressure%20%281%29-190fbac1-001a-4fd9-976e-88d4e16e92d9.webp\" alt=\"Individualized Treatment Plans\" width=\"880\" height=\"495\" /></p>\n<p>In the pursuit of comprehensive blood pressure management, medical interventions play a crucial role, offering targeted approaches to achieve and maintain optimal cardiovascular health.</p>\n<ul>\n<li><strong>Antihypertensive Medications:</strong></li>\n</ul>\n<p>When lifestyle modifications alone prove insufficient in achieving blood pressure goals, healthcare providers may turn to antihypertensive medications. These pharmaceutical agents are designed to exert specific effects on the cardiovascular system, effectively lowering blood pressure. The choice of medication is often tailored to individual health considerations, including the presence of coexisting medical conditions, potential side effects, and the overall response to treatment. Antihypertensive drugs encompass various classes, such as angiotensin-converting enzyme (ACE) inhibitors, beta-blockers, diuretics, and calcium channel blockers. Regular monitoring is essential to assess the medication's efficacy and adjust the treatment plan as needed.</p>\n<ul>\n<li><strong>Regular Blood Pressure Monitoring:</strong></li>\n</ul>\n<p>A cornerstone of effective hypertension management is the regular monitoring of blood pressure. This practice serves a dual purpose &ndash; empowering individuals to track their cardiovascular health at home and providing healthcare providers with valuable data during clinical visits. Home blood pressure monitoring devices offer convenience and the ability to capture a broader picture of daily fluctuations. This continuous monitoring aids healthcare professionals in making informed decisions regarding medication adjustments, lifestyle modifications, and overall treatment strategies. The collaborative effort between individuals and healthcare providers, facilitated by consistent blood pressure monitoring, enhances the precision of interventions.</p>\n<ul>\n<li><strong>Individualized Treatment Plans:</strong></li>\n</ul>\n<p>Recognizing the uniqueness of each individual's health profile, healthcare providers craft individualized treatment plans for blood pressure management. These plans consider a multitude of factors, including age, overall health status, presence of comorbidities, and individual response to medications. The goal is to tailor interventions to the specific needs and characteristics of each patient, ensuring that the chosen treatment aligns with their lifestyle, preferences, and health priorities. The individualized approach not only optimizes treatment outcomes but also fosters a collaborative and patient-centered healthcare experience.</p>\n<ul>\n<li><strong>Managing Underlying Conditions:</strong></li>\n</ul>\n<p>Comprehensive blood pressure management extends beyond addressing hypertension alone; it involves managing and mitigating underlying conditions that may contribute to elevated blood pressure. Common comorbidities include diabetes, high cholesterol, and kidney disease. Healthcare providers implement strategies to control these conditions, recognizing their interconnected impact on cardiovascular health. By managing underlying conditions, healthcare professionals strive to create a foundation of overall well-being, addressing the intricate interplay of factors influencing blood pressure regulation. This integrative approach exemplifies the commitment to holistic healthcare, acknowledging that effective blood pressure management is embedded in the broader context of an individual's health journey.</p>\n<p>&nbsp;</p>\n<h2>Embracing a Holistic Approach</h2>\n<ol>\n<li>\n<p><strong>Stress Management:</strong></p>\n<ul>\n<li>Chronic stress can contribute to elevated blood pressure. Incorporating stress-management techniques such as meditation, deep breathing exercises, and mindfulness into daily routines promotes overall well-being.</li>\n</ul>\n</li>\n<li>\n<p><strong>Regular Health Check-ups:</strong></p>\n<ul>\n<li>Regular health check-ups facilitate ongoing monitoring of blood pressure and allow healthcare providers to adjust treatment plans as needed. These check-ups also provide an opportunity to address emerging health concerns.</li>\n</ul>\n</li>\n<li>\n<p><strong>Patient Education:</strong></p>\n<ul>\n<li>Educating individuals about the importance of blood pressure management, potential risks of hypertension, and the role of lifestyle modifications empowers them to actively participate in their cardiovascular health.</li>\n</ul>\n</li>\n</ol>\n<p>&nbsp;</p>\n<h2>Conclusion</h2>\n<p>\"A Guide to Comprehensive Blood Pressure Management\" serves as a roadmap for individuals seeking to safeguard their cardiovascular health. By embracing lifestyle modifications, medical interventions, and a holistic approach to well-being, individuals can take charge of their blood pressure management journey. This guide aims to inspire a proactive and informed approach, ultimately leading to healthier hearts and a higher quality of life.</p>";

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

        Console.WriteLine("Text only: ");
        Console.WriteLine("{0}",
            string.Join(" ",
                readonlySource.Select(x => x.Text))
                .Replace("\n", " ")
                .Replace("\"", "\\\""));
        Console.WriteLine("Text only: ");

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