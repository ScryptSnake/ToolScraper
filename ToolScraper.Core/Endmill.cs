using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolScraper.Core;
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
    ToolTypes ToolType,
    WorkCenterTypes WorkCenterType,
    MaterialTypes Material,
    string MaterialDescription,
    bool Indexable,

    // End Mill
    int FluteCount,
    decimal CuttingDiameter,
    decimal ShankDiameter,
    decimal EffectiveLength,
    decimal OverallLength,
    decimal CornerRadius,
    string Iso
) : IEndMill;
