using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocVchr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvDocHCu { get; set; }
        public string InvDocHDs { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public decimal? InvDocVchrDebit { get; set; }
        public decimal? InvDocVchrCredit { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public int InvInvtSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int? InvDocVchrSi { get; set; }
        public string InvDocVchrTp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
    }
}
