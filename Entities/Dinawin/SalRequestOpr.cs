using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRequestOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRequestOprSi { get; set; }
        public int SalRequestHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalRequestOprValue { get; set; }
        public decimal SalRequestOprCalcValue { get; set; }

        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalRequestH SalRequestHSiNavigation { get; set; }
    }
}
