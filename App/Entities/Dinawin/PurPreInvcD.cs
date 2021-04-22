using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurPreInvcD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurPreInvcDSi { get; set; }
        public int? PurPreInvcHSi { get; set; }
        public int? PurOrderDSi { get; set; }
        public double? PurPreInvcDQty { get; set; }
        public decimal? PurPreInvcDPrice { get; set; }
        public string PurPreInvcDDesc { get; set; }

        public virtual PurPreInvcH PurPreInvcHSiNavigation { get; set; }
    }
}
