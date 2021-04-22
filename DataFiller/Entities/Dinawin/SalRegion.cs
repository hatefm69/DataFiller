using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRegion : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRegionSi { get; set; }
        public string SalRegionCu { get; set; }
        public int? SalCitySi { get; set; }
        public string SalRegionTp { get; set; }
    }
}
