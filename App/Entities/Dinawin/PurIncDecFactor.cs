using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurIncDecFactor : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurIncDecFactorSi { get; set; }
        public int PurIncDecFactorTypeSi { get; set; }
        public int PurBuyDSi { get; set; }
        public decimal PurIncDecFactorAmnt { get; set; }
        public double? PurIncDecFactorPerc { get; set; }
        public string PurIncDecFactorDesc { get; set; }

        public virtual PurBuyD PurBuyDSiNavigation { get; set; }
        public virtual PurIncDecFactorType PurIncDecFactorTypeSiNavigation { get; set; }
    }
}
