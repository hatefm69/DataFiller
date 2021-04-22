using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocDsrl : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvDocHCu { get; set; }
        public string InvDocHDs { get; set; }
        public string InvDocDsrlSrl { get; set; }
        public string InvDocTypTp { get; set; }
        public int InvGdsSi { get; set; }
        public int InvDocHSi { get; set; }
        public int InvInvtSi { get; set; }
        public int InvDocTypSi { get; set; }
        public string InvDocDsrlDestroySts { get; set; }
        public bool? InvDocDsrlDestroy { get; set; }
    }
}
