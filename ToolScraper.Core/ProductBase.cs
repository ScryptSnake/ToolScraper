using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core;


/// <summary>
/// Represents the high level details about a product/item.
/// </summary>
public abstract class ProductBase
{
    public required string Id { get; init; }
    public required string Description { get; init; }
    public required string Country { get; init; }
    public decimal Weight { get; init; }
    public Uri? Url { get; init; }
}

public abstract class Tool : ProductBase
{
    public required string Material { get; init; }
    public required string Description { get; init; }
    public required string Country { get; init; }
    public decimal Weight { get; init; }
    public Uri? Url { get; init; }
}

public abstract class MillingTool
{
    public required string Id { get; init; }
    public required string Description { get; init; }
    public required string Country { get; init; }
    public decimal Weight { get; init; }
    public Uri? Url { get; init; }
}
