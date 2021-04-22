using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalBrnchUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalBrnchUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalBrnchSi { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
    }
}
