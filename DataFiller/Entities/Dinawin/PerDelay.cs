using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerDelay : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerDelaySi { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public string PerOprCu { get; set; }
    }
}
