using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using ToolScraper.Core.Types;

namespace ToolScraper.Core.Scrapers
{

    // Scrapes the kennametal website for an endmill. 
    public class EndMillScraper : IScraper<EndMill>
    {
        private const string BASE_URL = "https://www.kennametal.com/us/en/products/";
        private HttpClient Client { get; }
        private Uri? Uri { get; set; }



        /// <summary>
        /// Instantiates a new EndMillScraper. 
        /// This object scrapes the Kennametal website based on a KMT number. 
        /// </summary>
        /// <param name="client"> Note: the client should be produced via IHttpFactory. </param>
        public EndMillScraper(HttpClient client)
        {
            Client = client;
            Uri = null; 
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

        // A helper function to get a spec (key) from the dictionary,
        // Finds matches that 'contain' the provided specName parameter. 
        // Casts the string value in the dict to the specified type. 
        private T FindItem<T>(IDictionary<string,string> dict, string specName, T defaultValue)
        {
            var key = dict.Keys.FirstOrDefault(key => key.Contains(specName));
            if (key == default)
            {
                Console.WriteLine("KEY = " + specName);
                return defaultValue; //Not found
            }

            // Cast the dictionary value (string) to T and return. 
            var value = (T)Convert.ChangeType(dict[key], typeof(T));
            return value;
        }




        public ScraperResult<EndMill> Scrape(string parameter)
        {
            throw new NotImplementedException();
        }

        public async Task<ScraperResult<EndMill>> ScrapeAsync(string parameter)
        {
            try
            {
                var endmill = await RunScrapeAsync(parameter);
                return new ScraperResult<EndMill>(true, endmill, Uri, null);
            }
            catch (Exception ex)
            {
                return new ScraperResult<EndMill>(false,null,Uri,ex.Message);
            }

        }



        /// <summary>
        /// Scrape and assemble an Endmill. 
        /// This only works for Flat Endmills from Kennametal. 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private async Task<EndMill> RunScrapeAsync(string parameter)
        {

            // Assemble a URL for the request. parameter = KMT number.
            // Set class property.
            var url = $"{BASE_URL}/p.{parameter}.html";
            this.Uri = new Uri(url);

            // Grab the .html body from Response.
            var response = await Client.GetStringAsync(url);

            // Create a html doc object.
            var html = new HtmlDocument();
            html.LoadHtml(response);

            // Grab name
            var description = html.DocumentNode.SelectSingleNode
                ("//div[contains(@class, 'product-title')]/h1").InnerText ?? "Unknown";

            // Grab description
            var name = html.DocumentNode.SelectSingleNode
                ("//div[contains(@class, 'product-subtitle')]/h2").InnerText ?? "Unknown";


            // Search for product images.
            var node = html.DocumentNode.SelectSingleNode
                ("//div[contains(@class, 'section-content')]");
            var imageNodes = node.SelectNodes(".//img");

            // Grab image urls, put into Uri array, 
            var imageUris = imageNodes
                .Select(img => new Uri(img.GetAttributeValue("src", string.Empty)))
                .ToArray();

            // Find the spec table in the doc body
            var xPath = "//table[contains(@class, 'p-esp-table')]/tbody";
            var tableNode = html.DocumentNode.SelectSingleNode(xPath);

            // Get a dictionary of specs from the table node
            var specs = await ParseTableAsync(tableNode);
            Console.WriteLine(String.Join("-", specs));

            // Find the corner treatment type.
            // Appears that Kennametal only offers radius or sharp.
            // Check if corner rad included in spec table, else = flat. 
            var cornerType = EndMillCornerTreatments.Sharp;
            var cornerRad = FindItem<decimal>(specs, "[Re]", 0);
            if(cornerRad==0)
                cornerType = EndMillCornerTreatments.Sharp;

            // Assemble EndMill item..
            var endmill = new EndMill(
            
                Id: parameter,
                Name: name,
                Description: description,
                Country: "USA",
                Weight: 0,
                Url: new Uri(url),
                Media: imageUris ?? Array.Empty<Uri>(), // Handle null for Media if necessary
                Material: MaterialTypes.Carbide,
                MaterialDescription: FindItem<string>(specs, "Grade", ""),
                FluteCount: FindItem<int>(specs, "[Z]", 0),
                CuttingDiameter: FindItem<decimal>(specs, "[D1]", 0),
                ShankDiameter: FindItem<decimal>(specs, "[D]", 0),
                EffectiveLength: FindItem<decimal>(specs, "[L3]", 0),
                OverallLength: FindItem<decimal>(specs, "[L]", 0),
                CornerTreatment: cornerType,
                CornerRadius: cornerRad,
                CornerEdgeBreak: 0,
                Iso: FindItem<string>(specs, "ISO Catalog ID", "")

            );

            return endmill;
        }

        public ScraperResult<EndMill> ScrapeMultiple(string[] parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<ScraperResult<EndMill>> ScrapeMultipleAsync(string[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
