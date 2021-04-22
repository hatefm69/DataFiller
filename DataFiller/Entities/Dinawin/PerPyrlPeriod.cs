using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPyrlPeriod : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerPyrlPeriod()
        {
            PerAdv = new HashSet<PerAdv>();
            PerLoanGivBak = new HashSet<PerLoanGivBak>();
            PerVchrH = new HashSet<PerVchrH>();
            PerWrkLst = new HashSet<PerWrkLst>();
        }

        public int PerPyrlPeriodSi { get; set; }
        public string PerPyrlPeriodTp { get; set; }
        public bool? PerPyrlPeriodCalculated { get; set; }
        public string PerPyrlPeriodDsStart { get; set; }
        public string PerPyrlPeriodDsEnd { get; set; }
        public int PerPyrlPeriodWrkDays { get; set; }
        public int? AccDocHSi { get; set; }
        public int? PerLocGrpSi { get; set; }

        public virtual AccHdoc AccDocHSiNavigation { get; set; }
        public virtual ICollection<PerAdv> PerAdv { get; set; }
        public virtual ICollection<PerLoanGivBak> PerLoanGivBak { get; set; }
        public virtual ICollection<PerVchrH> PerVchrH { get; set; }
        public virtual ICollection<PerWrkLst> PerWrkLst { get; set; }
    }
}
