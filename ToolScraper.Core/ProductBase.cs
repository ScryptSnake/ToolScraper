using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolScraper.Core.Types;

namespace ToolScraper.Core;

/// <summary>
/// Represents the high level details about a product/item.
/// </summary>
public interface IProduct
{
    string Id { get; init; }
    string Description { get; init; }
    string Country { get; init; }
    decimal Weight { get; init; }
    Uri? Url { get; init; }
}

/// <summary>
/// Represents a generic tool object, a specialized form of a product. 
/// </summary>
public interface ITool: IProduct
{
    string Iso { get; init; }   
    ToolTypes ToolType { get; init; }
    WorkCenterTypes WorkCenterType { get;init; }
    MaterialTypes Material { get; init; }
    string MaterialDescription { get; init; }
    bool Indexable { get; init; }
}

/// <summary>
/// Represents a specific tool:  Milling Tool. 
/// </summary>
public interface IEndMill: ITool
{
    int FluteCount { get; init; } 
    decimal CuttingDiameter { get; init; }  
    decimal ShankDiameter { get; init; }
    decimal EffectiveLength { get; init; }
    decimal OverallLength { get; init; }
    decimal CornerRadius { get; init; }

}
