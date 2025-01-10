using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolScraper.Core.Types;

namespace ToolScraper.Core.Products;

/// <summary>
/// Represents the high level details about a product/item.
/// </summary>
public interface IProduct
{
    string Id { get; init; }
    string Name { get; init; }
    string Description { get; init; }
    string Country { get; init; }
    decimal Weight { get; init; }
    Uri? Url { get; init; }
    Uri[]? Media { get; init; }
}

