using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core.Scrapers
{
    // Returned from an IScraper<T>'s Scrape method. Encapsulated the result and a success boolean. 
    public record ScraperResult<T>(bool Success, T? Result, Uri? requestUrl, string? error)
    {

    }
}
