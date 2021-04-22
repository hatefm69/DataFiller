using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvCntD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCntDSi { get; set; }
        public int InvCntHSi { get; set; }
        public int? InvCntDTag { get; set; }
        public int InvGdsSi { get; set; }
        public double InvCntDN1 { get; set; }
        public double InvCntDN2 { get; set; }
        public double InvCntDN3 { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? InvGdsToInvQtyReal { get; set; }
        public double? InvCntDN { get; set; }
        public string InvGdsToInvShelf { get; set; }
    }
}
