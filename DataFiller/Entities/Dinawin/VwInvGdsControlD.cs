using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGdsControlD : DinawinBaseEntity, IMyEntityDinawin
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
        public double? InvControlGdsAql { get; set; }
        public double? InvControlGdsBulK { get; set; }
        public double? InvControlGdsIncorectQty { get; set; }
        public double? InvControlGdsLackQty { get; set; }
        public string InvControlGdsPrsStudy { get; set; }
        public string InvControlGdsTp { get; set; }
        public int? InvControlGdsSi { get; set; }
    }
}
