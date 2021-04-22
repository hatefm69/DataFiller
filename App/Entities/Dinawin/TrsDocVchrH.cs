using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDocVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDocVchrHSi { get; set; }
        public int TrsDcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsDocVchrHTp { get; set; }
        public decimal TrsDocVchrHDebit { get; set; }
        public decimal TrsDocVchrHCredit { get; set; }
        public decimal? TrsDocVchrHDebitC { get; set; }
        public decimal? TrsDocVchrHCreditC { get; set; }
        public int? AccDocHSi { get; set; }

        public virtual TrsDc TrsDcSiNavigation { get; set; }
    }
}
