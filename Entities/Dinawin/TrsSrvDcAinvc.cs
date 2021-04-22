using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsSrvDcAinvc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsSrvDcAinvcSi { get; set; }
        public int TrsDcASi { get; set; }
        public int SalInvcSrvHSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustTp { get; set; }
        public int? SalInvcSrvHCu { get; set; }
        public string SalInvcSrvHDs { get; set; }
        public decimal? SalInvcSrvHPrcTotal { get; set; }
        public decimal? TrsPrice { get; set; }
        public decimal? RemainPrc { get; set; }
        public string SalTypTp { get; set; }
        public double? SalPrc { get; set; }
    }
}
