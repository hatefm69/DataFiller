using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPayrollDelayed : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPayrollDelayedSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public int PerPyrlPeriodSi { get; set; }
        public string PerPayrollDelayedCu { get; set; }
        public string PerPayrollDelayedTp { get; set; }
        public string PerPayrollDelayedIf { get; set; }
        public string PerPayrollDelayedCalc { get; set; }
        public decimal? PerPayrollDelayedValue { get; set; }
        public int? PerPayrollDelayedSeq { get; set; }
        public int? PerCmdSi { get; set; }
    }
}
