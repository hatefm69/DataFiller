using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurRqstHcnfrm : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurRqstHcnfrm()
        {
            PurRqstH = new HashSet<PurRqstH>();
        }

        public byte PurRqstHcnfrmSi { get; set; }
        public string PurRqstHcnfrmTp { get; set; }

        public virtual ICollection<PurRqstH> PurRqstH { get; set; }
    }
}
