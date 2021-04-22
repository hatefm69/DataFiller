using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtChangeCostD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtChangeCostDSi { get; set; }
        public int BgtChangeCostHSi { get; set; }
        public int SiAccM { get; set; }
        public byte BgtChangeCostDAdjCoef { get; set; }
        public decimal BgtChangeCostDCost { get; set; }

        public virtual BgtChangeCostH BgtChangeCostHSiNavigation { get; set; }
        public virtual CtbAccM SiAccMNavigation { get; set; }
    }
}
