using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolScraper.Core;
using ToolScraper.Core.Types;

namespace ToolScraper.Core;

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
