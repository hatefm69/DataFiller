using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvCntBatchD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCntBatchDSi { get; set; }
        public int InvCntHSi { get; set; }
        public int? InvCntBatchDTag { get; set; }
        public int InvGdsSi { get; set; }
        public double InvCntBatchDN1 { get; set; }
        public double InvCntBatchDN2 { get; set; }
        public double InvCntBatchDN3 { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? InvGdsToInvQtyReal { get; set; }
        public double? InvCntBatchDN { get; set; }
        public string InvGdsToInvShelf { get; set; }
        public string InvDocDExpNo { get; set; }
        public string InvGdsIcratrTp { get; set; }
        public string InvGdsIcratrCu { get; set; }
        public DateTime? InvDocDExpirDateM { get; set; }
    }
}
