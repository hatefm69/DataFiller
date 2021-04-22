using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalPreInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalPreInvcHSi { get; set; }
        public int SalPreInvcOprSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalPreInvcOprValue { get; set; }
        public decimal SalPreInvcOprCalcValue { get; set; }
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
        public int? SalCustSi { get; set; }
        public string SalPreInvcHDs { get; set; }
        public int? SalPreInvcHCu { get; set; }
        public int? Expr1 { get; set; }
        public int? SalTypSi { get; set; }
    }
}
