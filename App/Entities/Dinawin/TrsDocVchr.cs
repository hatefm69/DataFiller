using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDocVchr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDocVchrSi { get; set; }
        public int? TrsDccSi { get; set; }
        public int? TrsDcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsDocVchrTp { get; set; }
        public decimal TrsDocVchrDebit { get; set; }
        public decimal TrsDocVchrCredit { get; set; }
        public decimal? TrsDocVchrDebitC { get; set; }
        public decimal? TrsDocVchrCreditC { get; set; }
        public int? AccDocHSi { get; set; }

        public virtual TrsDc TrsDcSiNavigation { get; set; }
    }
}
