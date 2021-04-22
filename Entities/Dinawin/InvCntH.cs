using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCntH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvCntH()
        {
            InvCntD = new HashSet<InvCntD>();
        }

        public int InvCntHSi { get; set; }
        public string InvCntHDs { get; set; }
        public string InvCntHTp { get; set; }
        public int InvInvtSi { get; set; }

        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual ICollection<InvCntD> InvCntD { get; set; }
    }
}
