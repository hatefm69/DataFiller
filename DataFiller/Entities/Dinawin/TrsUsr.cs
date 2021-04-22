using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsUsr()
        {
            TrsUsrToGrp = new HashSet<TrsUsrToGrp>();
        }

        public int TrsUsrSi { get; set; }
        public string TrsUsrTp { get; set; }
        public string LoginName { get; set; }

        public virtual ICollection<TrsUsrToGrp> TrsUsrToGrp { get; set; }
    }
}
