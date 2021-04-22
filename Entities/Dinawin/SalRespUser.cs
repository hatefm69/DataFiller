using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRespUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRespUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalRespSi { get; set; }

        public virtual SalResp SalRespSiNavigation { get; set; }
    }
}
