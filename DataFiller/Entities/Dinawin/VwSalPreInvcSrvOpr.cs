using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalPreInvcSrvOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalPreInvcSrvOprSi { get; set; }
        public int SalPreInvcSrvHSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalPreInvcSrvOprValue { get; set; }
        public decimal SalPreInvcSrvOprCalcValue { get; set; }
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public byte? SalOprValueTyp { get; set; }
        public short? SalOprTyp { get; set; }
        public byte? SalOprSqnc { get; set; }
        public byte? SalOprSqncPrn { get; set; }
        public bool? SalOprActive { get; set; }
        public string SalOprNature { get; set; }
        public bool? SalOprAutoInsert { get; set; }
        public byte? SalOprUse { get; set; }
        public byte? SalOprLckPrc { get; set; }
        public int? SalPreInvcSrvHCu { get; set; }
        public string SalPreInvcSrvHDs { get; set; }
        public int? SalTypSi { get; set; }
    }
}
