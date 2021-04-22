using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRegionPath : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRegionPathSi { get; set; }
        public int SalRegionSi { get; set; }
        public string SalRegionPathCu { get; set; }
        public string SalRegionPathTp { get; set; }
    }
}
