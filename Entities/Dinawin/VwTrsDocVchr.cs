using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsDocVchr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? TrsDccSi { get; set; }
        public int? TrsDcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsDocVchrTp { get; set; }
        public decimal TrsDocVchrDebit { get; set; }
        public decimal TrsDocVchrCredit { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public int? AccDocHSi { get; set; }
    }
}
