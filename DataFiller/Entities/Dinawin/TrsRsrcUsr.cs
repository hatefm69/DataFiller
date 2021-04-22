using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsRsrcUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsRsrcSi { get; set; }
        public int TrsUsrGrpSi { get; set; }

        public virtual TrsRsrc TrsRsrcSiNavigation { get; set; }
        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
    }
}
