using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccLoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccLoc()
        {
            AccHdoc = new HashSet<AccHdoc>();
        }

        public int AccLocSi { get; set; }
        public string AccLocTp { get; set; }

        public virtual ICollection<AccHdoc> AccHdoc { get; set; }
    }
}
