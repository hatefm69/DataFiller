using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCdngH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvCdngH()
        {
            InvCdngD = new HashSet<InvCdngD>();
        }

        public int InvCdngHSi { get; set; }
        public string InvCdngHTp { get; set; }
        public int? InvCdngHSqnc { get; set; }
        public int? InvCdngHTpSqnc { get; set; }
        public bool? InvCdngHVsTp { get; set; }
        public bool? InvCdngHVsCu { get; set; }

        public virtual ICollection<InvCdngD> InvCdngD { get; set; }
    }
}
