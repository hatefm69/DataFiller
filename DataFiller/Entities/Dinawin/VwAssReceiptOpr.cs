using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAssReceiptOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? AssReceiptHCu { get; set; }
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
        public string SalOprNature { get; set; }
        public int? SalOprAccMSi { get; set; }
        public int? SalOprAccTSi { get; set; }
        public int AssReceiptOprSi { get; set; }
        public int? SalOprSi { get; set; }
        public int? AssReceiptHSi { get; set; }
        public double? AssReceiptOprValue { get; set; }
        public double? AssReceiptOprCalcValue { get; set; }
        public int? AssReceiptOprAccMSi { get; set; }
        public int? AssReceiptOprAccTSi { get; set; }
        public string AssReceiptHDescription { get; set; }
    }
}
