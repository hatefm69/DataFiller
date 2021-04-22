using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGdsAcc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalGdsAccSi { get; set; }
        public int InvGdsSi { get; set; }
        public int SalGdsAccAccMSi { get; set; }
        public int? SalGdsAccAccTSi { get; set; }
        public int? SalGdsAccAccCSi { get; set; }
        public int? SalGdsAccAccPSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual CtbAccM SalGdsAccAccMSiNavigation { get; set; }
        public virtual CtbAccT SalGdsAccAccTSiNavigation { get; set; }
    }
}
