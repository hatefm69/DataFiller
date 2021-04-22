using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraMnuToUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int FaraMnuToUsrSi { get; set; }
        public int? FaraMnuSi { get; set; }
        public string LoginName { get; set; }

        public virtual FaraMnu FaraMnuSiNavigation { get; set; }
    }
}
