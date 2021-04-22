using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalPreInvcD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalPreInvcDSi { get; set; }
        public int SalPreInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? SalPreInvcDRow { get; set; }
        public double SalPreInvcDQty { get; set; }
        public double? SalPreInvcDQty2 { get; set; }
        public decimal SalPreInvcDUntPrc { get; set; }
        public decimal SalPreInvcDTotal { get; set; }
        public string SalPreInvcDTp { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalOprInc { get; set; }
        public decimal? SalOprDec { get; set; }
        public decimal? SalpreInvcDPrcDec { get; set; }
        public decimal? SalpreInvcDPrcInc { get; set; }
        public decimal? SalPreInvCdSumTotal { get; set; }
        public int? SalGiftInvGdsSi { get; set; }
        public string SalGiftInvGdsTp { get; set; }
        public double? SalGiftInvGdsTotal { get; set; }
        public double? SalGiftInvGdsQty { get; set; }
        public int? SalGiftDSi { get; set; }
        public bool? SalPreInvcDGiftOk { get; set; }
        public double? SalPreInvcDTotalC { get; set; }
        public double? SalPreInvcDUntPrcC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public decimal? SalpreInvcDPrcInc2 { get; set; }
        public decimal? SalPreInvcDPrcDec2 { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalPreInvcDSumPrcDec { get; set; }
        public double? SalPreInvcDSumPrcInc { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalpreInvcDPrcInc3 { get; set; }
        public double? SalPreInvcDPrcDec3 { get; set; }
        public string BatchNumberD { get; set; }
        public string InvBatchNumberCode { get; set; }
        public DateTime? SalPreInvcDExpiredate { get; set; }
        public double? Remain { get; set; }
        public double? SalPreInvcDGrntCust { get; set; }
        public double? SalPreInvcDCoefficientCust { get; set; }
        public double? SalPreInvcDTotalGrantCust { get; set; }
        public double? SalPreInvcDGrntIntrmd { get; set; }
        public double? SalPreInvcDCoefficientintrmd { get; set; }
        public double? SalPreInvcDTotalGrantIntrmd { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalPreInvcH SalPreInvcHSiNavigation { get; set; }
    }
}
