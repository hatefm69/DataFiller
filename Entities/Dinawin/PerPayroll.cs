using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPayroll : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPayrollSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public int PerPyrlPeriodSi { get; set; }
        public string PerPayrollCu { get; set; }
        public string PerPayrollTp { get; set; }
        public string PerPayrollIf { get; set; }
        public string PerPayrollCalc { get; set; }
        public decimal PerPayrollValue { get; set; }
        public int PerPayrollSeq { get; set; }
        public bool? PerPayrollDelayed { get; set; }
        public int? PerCmdSi { get; set; }
        public bool? PerPayrollIsmovagh { get; set; }
    }
}
