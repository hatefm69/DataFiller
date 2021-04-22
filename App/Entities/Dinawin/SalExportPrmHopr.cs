using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalExportPrmHopr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalExportPrmHoprSi { get; set; }
        public int? SalExportPrmHSi { get; set; }
        public int? SalOprSi { get; set; }
        public decimal? SalExportPrmHoprValue { get; set; }
        public decimal? SalExportPrmHoprCalcValue { get; set; }
    }
}
