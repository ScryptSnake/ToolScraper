using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core.Scrapers
{

    /// <summary>
    /// A generic interface to which a Scraper for a specific type must adhere. 
    /// </summary>
    /// <typeparam name="T"> The object to scrape. </typeparam>
    public interface IScraper<T> where T: class
    {
        public Uri Url { get;}

        public ScraperResult<T> Scrape();

        public Task<ScraperResult<T>> ScrapeAsync();

    }
}
