using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurBuyH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurBuyH()
        {
            PurBuyD = new HashSet<PurBuyD>();
            PurIncDecFactorH = new HashSet<PurIncDecFactorH>();
        }

        public int PurBuyHSi { get; set; }
        public DateTime? PurBuyHDt { get; set; }
        public string PurBuyHCu { get; set; }
        public string PurBuyHDs { get; set; }
        public byte? PurBuyHKind { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurOrdBuyHSi { get; set; }
        public string PurBuyHCustNo { get; set; }
        public decimal? PurBuyHPrice { get; set; }
        public string PurBuyHDesc { get; set; }
        public string PurBuyHFileName { get; set; }
        public byte[] PurBuyHFile { get; set; }

        public virtual ICollection<PurBuyD> PurBuyD { get; set; }
        public virtual ICollection<PurIncDecFactorH> PurIncDecFactorH { get; set; }
    }
}
