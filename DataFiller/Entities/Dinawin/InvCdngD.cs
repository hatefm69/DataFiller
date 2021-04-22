using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCdngD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCdngDSi { get; set; }
        public int InvCdngHSi { get; set; }
        public string InvCdngDCu { get; set; }
        public string InvCdngDTp { get; set; }
        public int? InvCdngDSqnc { get; set; }
        public string InvCdngDUid { get; set; }
        public string InvCdngDLnk { get; set; }

        public virtual InvCdngH InvCdngHSiNavigation { get; set; }
    }
}
