using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvRqstSts : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvRqstSts()
        {
            InvRqstD = new HashSet<InvRqstD>();
        }

        public byte InvRqstStsSi { get; set; }
        public string InvRqstStsTp { get; set; }

        public virtual ICollection<InvRqstD> InvRqstD { get; set; }
    }
}
