using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurBuyD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurBuyDSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PurBuyDQty { get; set; }
        public int? PurBuyHSi { get; set; }
        public double? PurBuyDPrc { get; set; }
    }
}
