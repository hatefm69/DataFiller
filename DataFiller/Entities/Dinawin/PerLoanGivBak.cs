using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerLoanGivBak : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerLoanGivBakSi { get; set; }
        public int PerLoanSi { get; set; }
        public string PerLoanGivBakDs { get; set; }
        public decimal PerLoanGivBakPrice { get; set; }
        public string PerLoanGivBakTp { get; set; }
        public int? PerPyrlPeriodSi { get; set; }

        public virtual PerLoans PerLoanSiNavigation { get; set; }
        public virtual PerPyrlPeriod PerPyrlPeriodSiNavigation { get; set; }
    }
}
