using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalPreInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalPreInvcOprSi { get; set; }
        public int SalPreInvcHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalPreInvcOprValue { get; set; }
        public decimal SalPreInvcOprCalcValue { get; set; }

        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalPreInvcH SalPreInvcHSiNavigation { get; set; }
    }
}
