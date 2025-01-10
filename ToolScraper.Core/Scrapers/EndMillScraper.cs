﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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


        // Helper method - Assembles a dictionary of specs found in the tableNode
        private async Task<ReadOnlyDictionary<string,string>> ParseTableAsync(HtmlNode tableNode)
        {
            var output = new Dictionary<string, string>();

            // Select all the tables rows in tableNode.
            var nodes = tableNode.SelectNodes(".//tr");

            // Loop through each row, there are 2 <td>s for every row.
            // First is spec, second is value. 
            // There are 2 rows for a single spec (inch and metric)
            foreach (var node in nodes)
            {
                var rowData = node.SelectNodes("td");
                var spec = rowData[0].InnerText.Trim();
                var value = rowData[1].InnerText.Trim();

                // Check units, strip or ignore accordingly.
                if (value.Length >= 3)
                {
                    var units = value.Substring(value.Length - 3);
                    if (units == " in")
                    {
                        // strip inch. 
                        value = value.Substring(0, value.Length - 3);   
                    }else if (units == " mm")
                    {
                        continue; // ignore metrics. 
                    }
                }

                output.Add(spec, value);
            }
            return new ReadOnlyDictionary<string, string>(output);
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

            // Find the spec table in the doc body. It contains a css class 'p-esp-table'
            var xPath = "//table[contains(@class, 'p-esp-table')]/tbody";
            var tableNode = html.DocumentNode.SelectSingleNode(xPath);

            // Assemble an endmill from the table of specs:
            var specs = await ParseTableAsync(tableNode);
            Console.WriteLine(String.Join("-", specs));






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
