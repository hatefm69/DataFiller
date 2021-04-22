using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurRqstCuse : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurRqstCuse()
        {
            PurRqstH = new HashSet<PurRqstH>();
        }

        public int PurRqstCuseSi { get; set; }
        public string PurRqstCuseTp { get; set; }

        public virtual ICollection<PurRqstH> PurRqstH { get; set; }
    }
}
