using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssSrvHprs : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssSrvHprsSi { get; set; }
        public int? AssSrvHSi { get; set; }
        public int? AssPrsSi { get; set; }

        public virtual AssPersonel AssPrsSiNavigation { get; set; }
    }
}
