using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrderD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurOrderDSi { get; set; }
        public int? PurReqstDSi { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurOrdBuyDSi { get; set; }
        public int? PurOrdBuyHSi { get; set; }
        public int? PurBuyDSi { get; set; }

        public virtual PurOrderH PurOrderHSiNavigation { get; set; }
    }
}
