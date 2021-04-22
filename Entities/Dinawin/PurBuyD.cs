using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurBuyD : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurBuyD()
        {
            PurIncDecFactor = new HashSet<PurIncDecFactor>();
        }

        public int PurBuyDSi { get; set; }
        public double? PurBuyDQty { get; set; }
        public double? PurBuyDPrice { get; set; }
        public int? PurBuyHSi { get; set; }
        public int? PurPreInvcDSi { get; set; }
        public int? PurOrdBuyDSi { get; set; }
        public int? PurOrderDSi { get; set; }

        public virtual PurBuyH PurBuyHSiNavigation { get; set; }
        public virtual ICollection<PurIncDecFactor> PurIncDecFactor { get; set; }
    }
}
