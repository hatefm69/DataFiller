using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsAccP : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public int AccLpSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
