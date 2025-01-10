using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core.Scrapers
{

    // Scrapes the kennametal website for an endmill. 
    public class EndMillScraper : IScraper<EndMill>
    {
        private const string BASE_URL = "https://www.kennametal.com/us/en/products/";
        private HttpClient Client { get; }

        /// <summary>
        /// Instantiates a new EndMillScraper. 
        /// This object scrapes the Kennametal website based on a KMT number. 
        /// </summary>
        /// <param name="client"> Note: the client should be produced via IHttpFactory. </param>
        public EndMillScraper(HttpClient client)
        {
            Client = client;
        }


        public ScraperResult<EndMill> Scrape(string parameter)
        {
            throw new NotImplementedException();
        }

        public async Task<ScraperResult<EndMill>> ScrapeAsync(string parameter)
        {
            // Assemble a URL for the request. parameter = KMT number.
            var url = $"{BASE_URL}/p.{parameter}.html";

            // Grab the .html body from Response.
            var response = await Client.GetStringAsync(url);

            // Create a html doc object.
            var html = new HtmlDocument();
            html.LoadHtml(response);

            // Run a Xpath query on the doc to find table element.
            var xPath = "//table[contains(@class, 'p-esp-table')]";
            var targetNode = html.DocumentNode.SelectSingleNode(xPath);

            // For testing. 
            Console.Write("OUTPUT = " + targetNode.InnerText);


            // temporary - keep compiler happy. 
            return new ScraperResult<EndMill>(false, null, null, null);



        }

        public ScraperResult<EndMill> ScrapeMultiple(string[]? parameters = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ScraperResult<EndMill>> ScrapeMultipleAsync(string[]? parameters = null)
        {
            throw new NotImplementedException();
        }
    }
}
