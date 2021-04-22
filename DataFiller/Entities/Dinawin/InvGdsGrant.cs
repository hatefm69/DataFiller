using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsGrant : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsGrantSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? SalCustSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public double? InvGdsGrantCustQty { get; set; }
        public double? InvGdsGrantIntrmdQty { get; set; }
        public string InvGdsGrantDs { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
    }
}
