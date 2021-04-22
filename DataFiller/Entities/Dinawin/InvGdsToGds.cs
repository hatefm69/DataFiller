using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsToGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsToGdsSi { get; set; }
        public int? InvGdsSiM { get; set; }
        public int? InvGdsSiD { get; set; }
        public double? InvGdsToGdsQty { get; set; }
        public int? InvInvtSi { get; set; }
        public int? SiFather { get; set; }

        public virtual InvInvt InvInvtSiNavigation { get; set; }
    }
}
