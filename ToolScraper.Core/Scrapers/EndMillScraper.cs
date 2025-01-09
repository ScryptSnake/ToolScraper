using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core.Scrapers
{

    // Scrapes the kennametal website for an endmill. 
    public class EndMillScraper : IScraper<EndMill>
    {
        private const string baseUrl = "https://www.kennametal.com/us/en/products/";
        public Uri Url { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }


        public EndMillScraper(int KmtNumber)
        {
            var url = $"{baseUrl}/p.{KmtNumber}.html";
            Url = new Uri(url) ;

        }

        public ScraperResult<EndMill> Scrape()
        {
            throw new NotImplementedException();
        }

        public Task<ScraperResult<EndMill>> ScrapeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
