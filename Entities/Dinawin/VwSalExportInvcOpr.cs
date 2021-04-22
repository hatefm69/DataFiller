using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalExportInvcOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalExportPrmHSi { get; set; }
        public int SalExportPrmHoprSi { get; set; }
        public int? SalOprSi { get; set; }
        public decimal? SalExportPrmHoprValue { get; set; }
        public decimal? SalExportPrmHoprCalcValue { get; set; }
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public byte? SalOprValueTyp { get; set; }
        public short? SalOprTyp { get; set; }
        public byte? SalOprSqncPrn { get; set; }
    }
}
