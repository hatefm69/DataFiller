using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvControlGdsD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvControlGdsDSi { get; set; }
        public int? InvControlGdsSi { get; set; }
        public double? InvControlGdsDQty { get; set; }
        public int? InvControlGdsDIsTention { get; set; }
        public int? InvControlGdsDAcpt { get; set; }
        public bool? InvControlGdsDAccept1 { get; set; }
        public bool? InvControlGdsDAccept2 { get; set; }
        public bool? InvControlGdsDAcceptInv1 { get; set; }
        public bool? InvControlGdsDAcceptInv2 { get; set; }
        public double? InvControlGdsDQtyAccept1 { get; set; }
        public bool? InvControlGdsDIsback { get; set; }
        public bool? InvControlGdsDSndInv { get; set; }

        public virtual InvControlGds InvControlGdsSiNavigation { get; set; }
    }
}
