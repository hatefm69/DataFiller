using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvControlGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvDocTmpHCu { get; set; }
        public string InvDocTmpHDs { get; set; }
        public DateTime? InvControlGdsStmpCdt { get; set; }
        public int? InvGdsResultSi { get; set; }
        public string InvGdsResultTp { get; set; }
        public int? InvDocTmpHSi { get; set; }
        public int? InvDocTmpDSi { get; set; }
        public int? InvControlGdsSts { get; set; }
        public int? InvInvtSi { get; set; }
        public bool? InvControlGdsSndInv { get; set; }
        public string InvControlGdsStmpMus { get; set; }
        public DateTime? InvControlGdsAcptCdt { get; set; }
        public string InvControlGdsAcptMus { get; set; }
        public string InvControlGdsStmpTim { get; set; }
        public string InvControlGdsAcptTim { get; set; }
        public string InvControlGdsCu { get; set; }
        public double? InvDocTmpDQty { get; set; }
        public double? InvControlGdsLackQty { get; set; }
        public double? InvControlGdsBulK { get; set; }
        public double? InvControlGdsIncorectQty { get; set; }
        public double? InvControlGdsAql { get; set; }
        public double? InvDocTmpDQtyAccept { get; set; }
        public int? PurVndrSi { get; set; }
        public int? InvControlGdsSi { get; set; }
        public int? InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public bool? InvControlGdsAcs1 { get; set; }
        public bool? InvControlGdsAcs2 { get; set; }
        public bool? InvControlGdsAccept1 { get; set; }
        public bool? InvControlGdsAccept2 { get; set; }
        public bool? InvControlGdsIsTention { get; set; }
        public double? InvControlGdsQtyAccept1 { get; set; }
        public double? InvControlGdsQtyAccept2 { get; set; }
    }
}
