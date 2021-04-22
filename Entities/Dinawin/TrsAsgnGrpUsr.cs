using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAsgnGrpUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TrsAsgnGrpSi { get; set; }
        public int TrsUsrGrpSi { get; set; }

        public virtual TrsAsgnGrp TrsAsgnGrpSiNavigation { get; set; }
        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
    }
}
