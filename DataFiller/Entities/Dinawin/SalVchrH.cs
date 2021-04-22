using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalVchrH()
        {
            SalVchrD = new HashSet<SalVchrD>();
        }

        public int SalVchrHId { get; set; }
        public DateTime SalVchrHDate { get; set; }
        public DateTime SalVchrHDateFrom { get; set; }
        public DateTime SalVchrHDateUntil { get; set; }
        public string SalVchrHTx { get; set; }
        public bool? SalVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }

        public virtual AccHdoc AccDocHSiNavigation { get; set; }
        public virtual ICollection<SalVchrD> SalVchrD { get; set; }
    }
}
