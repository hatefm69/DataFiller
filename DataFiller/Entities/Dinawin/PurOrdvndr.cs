using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrdvndr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurOrdVndrSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurOrderHSi { get; set; }

        public virtual PurOrderH PurOrderHSiNavigation { get; set; }
    }
}
