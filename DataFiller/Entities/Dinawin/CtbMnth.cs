using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbMnth : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbMnth()
        {
            TrsDc = new HashSet<TrsDc>();
            TrsDcS = new HashSet<TrsDcS>();
        }

        public byte CtbMnthSi { get; set; }
        public string CtbMnthTp { get; set; }

        public virtual ICollection<TrsDc> TrsDc { get; set; }
        public virtual ICollection<TrsDcS> TrsDcS { get; set; }
    }
}
