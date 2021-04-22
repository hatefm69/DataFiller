using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrdPayKind : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurOrdPayKind()
        {
            PurOrderH = new HashSet<PurOrderH>();
        }

        public int PurOrdPayKindSi { get; set; }
        public string PurOrdPayKindTp { get; set; }

        public virtual ICollection<PurOrderH> PurOrderH { get; set; }
    }
}
