﻿using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcOprSi { get; set; }
        public int SalInvcHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalInvcOprValue { get; set; }
        public decimal SalInvcOprCalcValue { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
    }
}