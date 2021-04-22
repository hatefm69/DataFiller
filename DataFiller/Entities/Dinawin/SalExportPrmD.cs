using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalExportPrmD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalExportPrmDSi { get; set; }
        public int? SalExportPrmHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? SalExportPrmDQty { get; set; }
        public double? SalExportPrmDQty2 { get; set; }
        public int? InvUntSi { get; set; }
        public decimal? SalExportPrmDTotal { get; set; }
        public decimal? SalExportPrmDUntPrc { get; set; }
        public double? SalExportPrmDPrcInc { get; set; }
        public double? SalExportPrmDPrcDec { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalExportPrmDSumTotal { get; set; }
        public int? SalGiftInvGdsSi { get; set; }
        public string SalGiftInvGdsTp { get; set; }
        public double? SalGiftInvGdsTotal { get; set; }
        public double? SalGiftInvGdsQty { get; set; }
        public bool? SalExportPrmDGiftOk { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalExportPrmDPrcDec2 { get; set; }
        public double? SalExportPrmDPrcInc2 { get; set; }
        public double? SalExportPrmDTotalC { get; set; }
        public double? SalExportPrmDUntPrcC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public int? SalGiftDSi { get; set; }
        public string SalExportPrmDTp { get; set; }
        public decimal? SalExportPrmDSumPrcDec { get; set; }
        public decimal? SalExportPrmDSumPrcInc { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalExportPrmDPrcDec3 { get; set; }
        public double? SalExportPrmDPrcInc3 { get; set; }
        public string BatchNumberD { get; set; }
        public DateTime? SalExportPrmDExpiredate { get; set; }

        public virtual SalExportPrmH SalExportPrmHSiNavigation { get; set; }
    }
}
