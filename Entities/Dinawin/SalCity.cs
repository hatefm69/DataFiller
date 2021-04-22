using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCity : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCitySi { get; set; }
        public int SalProvinceSi { get; set; }
        public double? SalCityCu { get; set; }
        public string SalCityTp { get; set; }
        public double? Cu2 { get; set; }

        public virtual SalProvince SalProvinceSiNavigation { get; set; }
    }
}
