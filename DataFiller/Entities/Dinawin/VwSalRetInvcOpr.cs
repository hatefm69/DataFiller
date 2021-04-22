using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalRetInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRetInvcHSi { get; set; }
        public int SalRetInvcOprSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalRetInvcOprValue { get; set; }
        public decimal SalRetInvcOprCalcValue { get; set; }
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public byte? SalOprValueTyp { get; set; }
        public short? SalOprTyp { get; set; }
        public byte? SalOprSqnc { get; set; }
        public byte? SalOprSqncPrn { get; set; }
        public bool? SalOprActive { get; set; }
        public byte? SalOprLckPrc { get; set; }
        public byte? SalOprUse { get; set; }
        public bool? SalOprAutoInsert { get; set; }
        public int? SalOprAccMSi { get; set; }
        public int? SalOprAccTSi { get; set; }
        public string SalOprNature { get; set; }
        public int? SalRetInvcHCu { get; set; }
        public bool? SalRetInvcHAccDoc { get; set; }
        public int? SalRetInvcOprAccMSi { get; set; }
        public int? SalRetInvcOprAccTSi { get; set; }
        public string SalRetInvcHTp { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalRetInvcHDs { get; set; }
    }
}
