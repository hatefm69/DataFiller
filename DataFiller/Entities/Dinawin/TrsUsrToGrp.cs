using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsUsrToGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsUsrGrpSi { get; set; }
        public int TrsUsrSi { get; set; }

        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
        public virtual TrsUsr TrsUsrSiNavigation { get; set; }
    }
}
