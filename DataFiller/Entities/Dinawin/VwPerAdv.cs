using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerAdv: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerAdvSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public int? PerAdvCu { get; set; }
        public string PerAdvDs { get; set; }
        public string PerAdvTp { get; set; }
        public decimal PerAdvPrice { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public int? PerLocSi { get; set; }
    }
}
