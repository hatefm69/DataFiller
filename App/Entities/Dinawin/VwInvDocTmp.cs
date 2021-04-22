using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocTmp : DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public int? InvDocTmpHCu { get; set; }
        public string InvDocTmpHDs { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string InvDocTmpHTp { get; set; }
        public string InvDocTmpHCu2 { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public double? InvDocTmpDQty { get; set; }
        public decimal? InvDocTmpDPrice { get; set; }
        public decimal? InvDocTmpDTotal { get; set; }
        public string InvDocTmpDTp { get; set; }
        public double? InvDocTmpDQtyAccept { get; set; }
        public double? InvDocTmpDQtyreturn { get; set; }
        public int InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int InvDocTmpDSi { get; set; }
        public int InvDocTmpHSi { get; set; }
        public DateTime? InvDocTmpHDm { get; set; }
    }
}
