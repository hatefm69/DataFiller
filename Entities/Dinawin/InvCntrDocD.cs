using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCntrDocD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCntrDocDSi { get; set; }
        public int? InvCntrDocHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? InvCntrDocDQty { get; set; }
        public int? InvUntSi { get; set; }
        public string InvCntrDocDTp { get; set; }
        public int? InvGdsTypSi { get; set; }

        public virtual InvCntrDocH InvCntrDocHSiNavigation { get; set; }
    }
}
