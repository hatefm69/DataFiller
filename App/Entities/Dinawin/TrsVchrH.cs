using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsVchrH()
        {
            TrsVchrD = new HashSet<TrsVchrD>();
        }

        public int TrsVchrHId { get; set; }
        public DateTime? TrsVchrHDate { get; set; }
        public DateTime? TrsVchrHDateFrom { get; set; }
        public DateTime? TrsVchrHDateUntil { get; set; }
        public string TrsVchrHTx { get; set; }
        public bool TrsVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }

        public virtual AccHdoc AccDocHSiNavigation { get; set; }
        public virtual ICollection<TrsVchrD> TrsVchrD { get; set; }
    }
}
