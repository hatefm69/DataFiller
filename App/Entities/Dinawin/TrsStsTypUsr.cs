using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsStsTypUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsStsTypSi { get; set; }
        public int TrsUsrGrpSi { get; set; }

        public virtual TrsStsTyp TrsStsTypSiNavigation { get; set; }
        public virtual TrsUsrGrp TrsUsrGrpSiNavigation { get; set; }
    }
}
