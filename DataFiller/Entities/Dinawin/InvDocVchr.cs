using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocVchr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocVchrSi { get; set; }
        public int InvDocHSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string InvDocVchrTp { get; set; }
        public decimal InvDocVchrDebit { get; set; }
        public decimal InvDocVchrCredit { get; set; }
        public decimal? InvDocVchrDebitC { get; set; }
        public decimal? InvDocVchrCreditC { get; set; }
    }
}
