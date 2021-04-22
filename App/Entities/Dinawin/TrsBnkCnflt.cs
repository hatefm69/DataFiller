using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsBnkCnflt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsBnkCnfltSi { get; set; }
        public int TrsRsrcSi { get; set; }
        public DateTime? TrsBnkCnfltDate { get; set; }
        public string TrsBnkCnfltDesc { get; set; }
        public int? TrsBnkCnfltNo { get; set; }
        public decimal? TrsBnkCnfltDebit { get; set; }
        public decimal? TrsBnkCnfltCredit { get; set; }
        public decimal? TrsBnkCnfltRmndr { get; set; }
        public int? TrsDcCSi { get; set; }
        public string TrsBnkCnfltTp { get; set; }
        public string TrsBnkCnfltAccNo { get; set; }
        public int? TrsDcCSiImg { get; set; }

        public virtual TrsRsrc TrsRsrcSiNavigation { get; set; }
    }
}
