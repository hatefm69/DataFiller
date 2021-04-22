using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPaySummeryInfo : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPaySummeryInfoSi { get; set; }
        public string PerPaySummerySum1Now { get; set; }
        public string PerPaySummerySum2Now { get; set; }
        public string PerPaySummerySum1Pre { get; set; }
        public string PerPaySummerySum2Pre { get; set; }
        public string PerPaySummerySumTaxNow { get; set; }
        public string PerPaySummerySumTaxPre { get; set; }
    }
}
