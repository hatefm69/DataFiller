using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrdBuyH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurOrdBuyH()
        {
            PurOrdBuyD = new HashSet<PurOrdBuyD>();
        }

        public int PurOrdBuyHSi { get; set; }
        public string PurOrdBuyHCu { get; set; }
        public DateTime? PurOrdBuyHDt { get; set; }
        public string PurOrdBuyHDs { get; set; }

        public virtual ICollection<PurOrdBuyD> PurOrdBuyD { get; set; }
    }
}
