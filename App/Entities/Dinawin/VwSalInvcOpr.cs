using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcHSi { get; set; }
        public int SalInvcOprSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalInvcOprValue { get; set; }
        public decimal SalInvcOprCalcValue { get; set; }
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
        public int? SalInvcHCu { get; set; }
        public bool? SalInvcHAccDoc { get; set; }
        public int? SalInvcOprAccMSi { get; set; }
        public int? SalInvcOprAccTSi { get; set; }
        public bool? SalInvcHCancelled { get; set; }
        public int? SalInvcHCu2 { get; set; }
        public string SalInvcHTp { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? SalCustSi { get; set; }
        public int? AccTSi { get; set; }
        public int? AccMSi { get; set; }
        public bool? SalOprProject { get; set; }
        public int? SalInvcHGood { get; set; }
        public string SalInvcHDs { get; set; }
        public int? SalTypSi { get; set; }
    }
}
