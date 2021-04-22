using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrdPayer : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurOrdPayer()
        {
            PurOrderH = new HashSet<PurOrderH>();
        }

        public int PurOrdPayerSi { get; set; }
        public string PurOrdPayerTp { get; set; }

        public virtual ICollection<PurOrderH> PurOrderH { get; set; }
    }
}
