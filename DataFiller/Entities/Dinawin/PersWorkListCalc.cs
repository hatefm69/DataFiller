using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PersWorkListCalc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PersWorkListCalcSi { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public int? CtbCostSi { get; set; }
        public double? PersWorkListCalcNightWork { get; set; }
        public double? PersWorkListCalcIncWorkTime { get; set; }
        public double? PersWorkListCalcDecWorkTime { get; set; }
        public double? PersWorkListCalcWorkList { get; set; }
    }
}
