using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGdsRetAcc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalGdsRetAccSi { get; set; }
        public int InvGdsSi { get; set; }
        public int SalGdsRetAccAccMSi { get; set; }
        public int? SalGdsRetAccAccTSi { get; set; }
        public int? SalGdsRetAccAccCSi { get; set; }
        public int? SalGdsRetAccAccPSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual CtbAccM SalGdsRetAccAccMSiNavigation { get; set; }
        public virtual CtbAccT SalGdsRetAccAccTSiNavigation { get; set; }
    }
}
