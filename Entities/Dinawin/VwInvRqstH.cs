using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvRqstH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvRqstHSi { get; set; }
        public int? InvRqstHCu { get; set; }
        public DateTime? InvRqstHDt { get; set; }
        public string InvRqstHTp { get; set; }
        public byte InvRqstTypSi { get; set; }
        public string InvRqstTypTp { get; set; }
        public int? InvDocHSi { get; set; }
        public string InvRqstHStmpCus { get; set; }
        public DateTime? InvRqstHStmpCdt { get; set; }
        public string InvRqstHStmpMus { get; set; }
        public DateTime? InvRqstHStmpMdt { get; set; }
        public bool? InvRqstHLock { get; set; }
    }
}
