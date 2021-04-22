using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalRegion : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalRegionCu { get; set; }
        public string SalRegionTp { get; set; }
        public string SalRegionPathCu { get; set; }
        public string SalRegionPathTp { get; set; }
        public int SalRegionPathSi { get; set; }
        public int SalRegionSi { get; set; }
    }
}
