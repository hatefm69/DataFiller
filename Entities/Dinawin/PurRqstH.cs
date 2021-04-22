using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurRqstH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurRqstH()
        {
            PurRqstD = new HashSet<PurRqstD>();
        }

        public int PurRqstHSi { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PurRqstCuseSi { get; set; }
        public int? InvInvtSi { get; set; }
        public DateTime? PurRqstHRdt { get; set; }
        public string PurRqstHTp { get; set; }
        public byte PurRqstHcnfrmSi { get; set; }
        public string PurRqstHCnfrmDesc { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual PurRqstCuse PurRqstCuseSiNavigation { get; set; }
        public virtual PurRqstHcnfrm PurRqstHcnfrmSiNavigation { get; set; }
        public virtual ICollection<PurRqstD> PurRqstD { get; set; }
    }
}
