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
        public ScraperResult<T> Scrape(string parameter);
        public Task<ScraperResult<T>> ScrapeAsync(string parameter);

        public ScraperResult<T> ScrapeMultiple(string[]? parameters = null);
        public Task<ScraperResult<T>> ScrapeMultipleAsync(string[]? parameters = null);

    }
}
