using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalInvcSrvOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcSrvHSi { get; set; }
        public int SalInvcSrvOprSi { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalInvcSrvOprValue { get; set; }
        public decimal SalInvcSrvOprCalcValue { get; set; }
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
        public int? SalInvcSrvHCu { get; set; }
        public bool? SalInvcSrvHAccDoc { get; set; }
        public int? SalInvcSrvOprAccMSi { get; set; }
        public int? SalInvcSrvOprAccTSi { get; set; }
        public string SalInvcSrvHTp { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
    }
}
