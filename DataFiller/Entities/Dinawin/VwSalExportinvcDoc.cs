using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalExportinvcDoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvDocHCu { get; set; }
        public string InvDocHDs { get; set; }
        public int? InvDocHSi { get; set; }
        public int? InvDocTypSi { get; set; }
        public int? SalExportPrmHSi { get; set; }
        public double? InvDocDQty { get; set; }
        public decimal? InvDocDPrice { get; set; }
        public decimal? InvDocDTotal { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
        public int? SalExportPrmHCu { get; set; }
        public string SalExportPrmHTp { get; set; }
        public decimal? SalExportPrmDTotal { get; set; }
        public decimal? SalExportPrmDUntPrc { get; set; }
        public double? SalExportPrmDQty { get; set; }
        public decimal? InvDocDPrice2 { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalExportPrmDPrcDec2 { get; set; }
        public double? SalExportPrmDPrcInc2 { get; set; }
        public decimal? SalExportPrmDSumPrcDec { get; set; }
        public decimal? SalExportPrmDSumPrcInc { get; set; }
        public double? SalExportPrmDPrcInc { get; set; }
        public double? SalExportPrmDPrcDec { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalExportPrmDSumTotal { get; set; }
        public double? InvDocDQty2 { get; set; }
        public string InvDocDExpNo { get; set; }
        public int? SalPreInvcHSi { get; set; }
    }
}
