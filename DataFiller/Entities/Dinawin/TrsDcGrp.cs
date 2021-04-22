using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsDcGrp()
        {
            TrsDc = new HashSet<TrsDc>();
        }

        public int TrsDcGrpSi { get; set; }
        public string TrsDcGrpTp { get; set; }

        public virtual ICollection<TrsDc> TrsDc { get; set; }
    }
}
