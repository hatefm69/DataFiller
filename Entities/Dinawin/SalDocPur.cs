using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDocPur : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDocPurSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string SalDocPurTp { get; set; }
        public decimal SalDocPurDebit { get; set; }
        public decimal SalDocPurCredit { get; set; }
    }
}
