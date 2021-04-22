using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocDsrl : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocDsrlId { get; set; }
        public int InvDocHSi { get; set; }
        public int? InvDocDSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public string InvDocDsrlSrl { get; set; }
        public int? InvDocTypSi { get; set; }
        public bool? InvDocDsrlLock { get; set; }
        public string InvDocDsrlTyp { get; set; }
        public bool? InvDocDsrlDestroy { get; set; }
        public int? InvInvtSi { get; set; }

        public virtual InvGdsTyp InvGds { get; set; }
    }
}
