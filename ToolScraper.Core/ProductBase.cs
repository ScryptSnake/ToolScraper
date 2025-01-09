using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core;

public abstract class ProductBase
{
    public required string Id { get; init; }
    public required string Country { get; init; }
    public decimal Weight { get; init; }
    public required string Description { get; init; }
    public Uri? Url { get; init; }
}
