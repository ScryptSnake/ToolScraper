using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolScraper.Core.Types;

namespace ToolScraper.Core.Products;

/// <summary>
/// Represents properties about a specialized type of tool: EndMill. 
/// </summary>
public interface IEndMill : ITool
{
    int FluteCount { get; init; }
    decimal CuttingDiameter { get; init; }
    decimal ShankDiameter { get; init; }
    decimal EffectiveLength { get; init; }
    decimal OverallLength { get; init; }
    EndMillCornerTreatments CornerTreatment { get; init; }  
    decimal CornerRadius { get; init; }
    decimal CornerEdgeBreak { get;init; }


}
