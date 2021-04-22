using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerVchrH()
        {
            PerVchrD = new HashSet<PerVchrD>();
        }

        public int PerVchrHId { get; set; }
        public DateTime? PerVchrHDate { get; set; }
        public DateTime? PerVchrHDateFrom { get; set; }
        public DateTime? PerVchrHDateUntil { get; set; }
        public string PerVchrHTx { get; set; }
        public bool? PerVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public int? PerLocSi { get; set; }

        public virtual PerPyrlPeriod PerPyrlPeriodSiNavigation { get; set; }
        public virtual ICollection<PerVchrD> PerVchrD { get; set; }
    }
}
