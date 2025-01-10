using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolScraper.Core.Types;

/// <summary>
/// The type of corner treatment an endmill can exhibit. 
/// Note:  Radius should be used for both corner radius tools as well as ball mills. 
/// </summary>
public enum EndMillCornerTreatments
{
   Sharp, EdgeBreak, Radius

}