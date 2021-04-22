using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCntBatchD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCntBatchDSi { get; set; }
        public int InvCntHSi { get; set; }
        public int? InvCntBatchDTag { get; set; }
        public int InvGdsSi { get; set; }
        public string InvDocDExpNo { get; set; }
        public double InvCntBatchDN1 { get; set; }
        public double InvCntBatchDN2 { get; set; }
        public double InvCntBatchDN3 { get; set; }
        public double? InvCntDqtyN1 { get; set; }
        public double? InvCntDqtyN2 { get; set; }
        public double? InvCntDqtyN3 { get; set; }
        public DateTime? InvDocDExpirDateM { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
