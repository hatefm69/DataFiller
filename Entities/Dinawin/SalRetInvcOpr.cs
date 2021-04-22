using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRetInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRetInvcOprSi { get; set; }
        public int SalRetInvcHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalRetInvcOprValue { get; set; }
        public decimal SalRetInvcOprCalcValue { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalRetInvcH SalRetInvcHSiNavigation { get; set; }
    }
}
