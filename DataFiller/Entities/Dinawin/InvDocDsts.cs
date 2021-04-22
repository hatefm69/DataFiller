using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocDsts : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDocDsts()
        {
            InvDocD = new HashSet<InvDocD>();
        }

        public byte InvDocDstsSi { get; set; }
        public string InvDocDstsTp { get; set; }

        public virtual ICollection<InvDocD> InvDocD { get; set; }
    }
}
