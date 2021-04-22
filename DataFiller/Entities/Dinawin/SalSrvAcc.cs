using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalSrvAcc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalSrvAccSi { get; set; }
        public int? SalSrvSi { get; set; }
        public int? SalSrvAccAccMSi { get; set; }
        public int? SalSrvAccAccTSi { get; set; }

        public virtual CtbAccM SalSrvAccAccMSiNavigation { get; set; }
        public virtual CtbAccT SalSrvAccAccTSiNavigation { get; set; }
        public virtual SalSrv SalSrvSiNavigation { get; set; }
    }
}
