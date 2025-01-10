using ToolScraper.Core;
using ToolScraper.Core.Products;
using ToolScraper.Core.Scrapers;
using ToolScraper.Core.Types;
namespace ConsoleDemoApp;


public class Program
{

    public static async Task Main(string[] args)
    {
        var client = new HttpClient();

        var scraper = new EndMillScraper(client);

        //var result =  await scraper.ScrapeAsync("7104182");
        var result = await scraper.ScrapeAsync("5970215");

        Console.ReadLine();

    }

}