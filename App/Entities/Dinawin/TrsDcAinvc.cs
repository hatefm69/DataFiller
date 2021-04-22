using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcAinvc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcAinvcSi { get; set; }
        public int TrsDcASi { get; set; }
        public int SalInvcHSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustTp { get; set; }
        public int? SalInvcHCu { get; set; }
        public string SalInvcHDs { get; set; }
        public decimal? SalInvcHPrcTotal { get; set; }
        public string SalTypTp { get; set; }
        public decimal? TrsPrice { get; set; }
        public decimal? RemainPrc { get; set; }
        public double? SalPrc { get; set; }
    }
}
