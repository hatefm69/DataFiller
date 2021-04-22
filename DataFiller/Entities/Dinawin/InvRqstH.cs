using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvRqstH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvRqstH()
        {
            InvRqstD = new HashSet<InvRqstD>();
        }

        public int InvRqstHSi { get; set; }
        public int? InvRqstHCu { get; set; }
        public DateTime? InvRqstHDt { get; set; }
        public string InvRqstHTp { get; set; }
        public byte InvRqstTypSi { get; set; }
        public int? InvDocHSi { get; set; }
        public int? PurReqstHSi { get; set; }
        public int? InvRqstHCuPur { get; set; }
        public int? InvinvtSi { get; set; }
        public bool? InvRqstHLock { get; set; }
        public string InvRqstHStmpTimeEdit { get; set; }
        public string InvRqstHStmpTime { get; set; }
        public string InvRqstHStmpCus { get; set; }
        public DateTime? InvRqstHStmpCdt { get; set; }
        public string InvRqstHStmpMus { get; set; }
        public DateTime? InvRqstHStmpMdt { get; set; }

        public virtual ICollection<InvRqstD> InvRqstD { get; set; }
    }
}
