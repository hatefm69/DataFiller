using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsAccC : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public int AccLcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
