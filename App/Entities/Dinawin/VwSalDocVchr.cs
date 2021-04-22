using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalDocVchr: DinawinBaseEntity, IMyEntityDinawin
    {
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public int? SalInvcHCu { get; set; }
        public string SalInvcHDs { get; set; }
        public string SalDocVchrTp { get; set; }
        public decimal SalDocVchrDebit { get; set; }
        public decimal SalDocVchrCredit { get; set; }
        public int? InvInvtSi { get; set; }
        public int? AccLtSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
    }
}
