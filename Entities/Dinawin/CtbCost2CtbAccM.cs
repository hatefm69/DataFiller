using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbCost2CtbAccM : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiCost2AccM { get; set; }
        public int SiCost { get; set; }
        public int SiAccM { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
        public virtual CtbCost SiCostNavigation { get; set; }
    }
}
