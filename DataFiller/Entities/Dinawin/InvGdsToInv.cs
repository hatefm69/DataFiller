using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsToInv : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsToInvSi { get; set; }
        public int InvInvtSi { get; set; }
        public int InvGdsSi { get; set; }
        public double InvGdsToInvQtyReal { get; set; }
        public double InvGdsToInvQtyVirtual { get; set; }
        public double InvGdsToInvQtyMin { get; set; }
        public double InvGdsToInvQtyMax { get; set; }
        public double InvGdsToInvQtySafe { get; set; }
        public string InvGdsToInvShelf { get; set; }
        public double? InvGdsToInvQtySale { get; set; }
        public int? InvGdsToInvTag { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvInvt InvInvtSiNavigation { get; set; }
    }
}
