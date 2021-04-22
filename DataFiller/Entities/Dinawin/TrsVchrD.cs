using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsVchrDId { get; set; }
        public int TrsVchrHId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsVchrDTx { get; set; }
        public decimal TrsVchrDDebit { get; set; }
        public decimal TrsVchrDCredit { get; set; }
        public string TrsVchrDDate { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual TrsVchrH TrsVchrH { get; set; }
    }
}
