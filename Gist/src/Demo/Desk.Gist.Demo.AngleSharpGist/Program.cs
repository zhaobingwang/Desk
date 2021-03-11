using System;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Html.Parser;

/// <summary>
/// Here is AngleSharp demo.
/// The documentation of AngleSharp is located in https://github.com/AngleSharp/AngleSharp/blob/master/doc/index.md
/// </summary>
namespace Desk.Gist.Demo.AngleSharpGist
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("AngleSharp Demo");
            Console.WriteLine();

            await GetCNBlogsSideRightData();
        }

        private static async Task GettingStartedAsync()
        {
            // Use the default configuration for AngleSharp
            var config = Configuration.Default;

            // Create a new context for evaluating webpages with the given config
            var context = BrowsingContext.New(config);

            // Source to be parsed
            var source = "<h1>Some example source</h1><p>This is a paragraph element";

            // Create a virtual request to specify the document to load (here from our fixed string)
            var document = await context.OpenAsync(req => req.Content(source));

            // Do something with document like the following
            Console.WriteLine("Serializing the (original) document:");
            Console.WriteLine(document.DocumentElement.OuterHtml);

            var p = document.CreateElement("p");
            p.TextContent = "This is another paragraph.";

            Console.WriteLine("Inserting another element in the body ...");
            document.Body.AppendChild(p);

            Console.WriteLine("Serializing the document again:");
            Console.WriteLine(document.DocumentElement.OuterHtml);
        }

        private static async Task GettingStartedAsync2()
        {
            // Use the default configuration for AngleSharp
            var config = Configuration.Default;

            // Create a new context for evaluating webpages with the given config
            var context = BrowsingContext.New(config);

            var parser = context.GetService<IHtmlParser>();

            // Source to be parsed
            var source = "<h1>Some example source</h1><p>This is a paragraph element";

            var document = parser.ParseDocument(source);

            // Do something with document like the following
            Console.WriteLine("Serializing the (original) document:");
            Console.WriteLine(document.DocumentElement.OuterHtml);

            var p = document.CreateElement("p");
            p.TextContent = "This is another paragraph.";

            Console.WriteLine("Inserting another element in the body ...");
            document.Body.AppendChild(p);

            Console.WriteLine("Serializing the document again:");
            Console.WriteLine(document.DocumentElement.OuterHtml);
        }

        private static async Task GetCNBlogsSideRightData()
        {
            var url = "https://www.cnblogs.com/aggsite/SideRight";
            var httpClient = new HttpClient();
            try
            {
                var responseHtml = await httpClient.GetStringAsync(url);
                var parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(responseHtml);

                var items = document.QuerySelectorAll(".card");
                foreach (var item in items)
                {
                    var currentHtml = item.OuterHtml;
                    var currentDocuemnt = await parser.ParseDocumentAsync(currentHtml);
                    Console.WriteLine(currentDocuemnt.QuerySelector(".card > h4 > a").TextContent);

                    var eles = currentDocuemnt.QuerySelectorAll(".card > .item-list > li a");
                    foreach (var ele in eles)
                    {
                        Console.WriteLine($"\t{ele.TextContent}\t{ele.GetAttribute("href")}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
