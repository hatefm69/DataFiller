using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCntD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCntDSi { get; set; }
        public int InvCntHSi { get; set; }
        public int? InvCntDTag { get; set; }
        public int InvGdsSi { get; set; }
        public double InvCntDN1 { get; set; }
        public double InvCntDN2 { get; set; }
        public double InvCntDN3 { get; set; }
        public double? InvCntDqtyN1 { get; set; }
        public double? InvCntDqtyN2 { get; set; }
        public double? InvCntDqtyN3 { get; set; }
        public double? InvCntDQty2 { get; set; }

        public virtual InvCntH InvCntHSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
