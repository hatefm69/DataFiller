using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcSrvOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcSrvOprSi { get; set; }
        public int SalInvcSrvHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalInvcSrvOprValue { get; set; }
        public decimal SalInvcSrvOprCalcValue { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual SalInvcSrvH SalInvcSrvHSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
    }
}
