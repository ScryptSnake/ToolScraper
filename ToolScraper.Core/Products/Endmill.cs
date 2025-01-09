using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolScraper.Core.Products;
using ToolScraper.Core.Types;

/// <summary>
/// A DTO to store information about an End Mill item. 
/// </summary>
public record EndMill(
    // Product
    string Id,
    string Description,
    string Country,
    decimal Weight,
    Uri? Url,

    // Tool
    MaterialTypes Material,
    string MaterialDescription,

    // End Mill
    int FluteCount,
    decimal CuttingDiameter,
    decimal ShankDiameter,
    decimal EffectiveLength,
    decimal OverallLength,
    decimal CornerRadius,
    string Iso
) : IEndMill
{
    // Default properties for ITool implementation:
    public bool Indexable { get; init; } = false;
    public ToolTypes ToolType { get; init; } = ToolTypes.Cutter;
    public WorkCenterTypes WorkCenterType { get; init; } = WorkCenterTypes.Milling;
}
