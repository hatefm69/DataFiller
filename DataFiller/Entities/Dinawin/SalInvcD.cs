using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcDSi { get; set; }
        public int SalInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? SalInvcDRow { get; set; }
        public decimal SalInvcDQty { get; set; }
        public decimal SalInvcDUntPrc { get; set; }
        public decimal SalInvcDTotal { get; set; }
        public string SalInvcDTp { get; set; }
        public string SalInvcDRno { get; set; }
        public DateTime? SalInvcDRds { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public decimal? SalDisCount { get; set; }
        public int? SalDisCountId { get; set; }
        public decimal? SalOprInc { get; set; }
        public decimal? SalOprDec { get; set; }
        public decimal? SalInvCdSumTotal { get; set; }
        public double? SalInvcDPrcDec { get; set; }
        public double? SalInvcDPrcInc { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public int? SalGiftInvGdsSi { get; set; }
        public string SalGiftInvGdsTp { get; set; }
        public double? SalGiftInvGdsTotal { get; set; }
        public double? SalGiftInvGdsQty { get; set; }
        public bool? SalInvcDGiftOk { get; set; }
        public int? SalGiftDSi { get; set; }
        public double? SalInvcDUntPrcC { get; set; }
        public double? SalInvcDTotalC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalInvcDPrcDec2 { get; set; }
        public double? SalInvcDPrcInc2 { get; set; }
        public double? SalInvcDSumPrcDec { get; set; }
        public double? SalInvcDSumPrcInc { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalInvcDPrcDec3 { get; set; }
        public double? SalInvcDPrcInc3 { get; set; }
        public double? SalInvcDQty2 { get; set; }
        public string BatchNumberD { get; set; }
        public DateTime? SalInvcDExpiredate { get; set; }
        public double? SalInvcDPurDebit { get; set; }
        public double? SalInvcDPurCredit { get; set; }
        public string SalInvcDPurDesc { get; set; }
        public DateTime? SalInvcDExpiredateSh { get; set; }
        public double? Remain { get; set; }
        public double? SalInvcDGrntCust { get; set; }
        public double? SalInvcDCoefficientCust { get; set; }
        public double? SalInvcDTotalGrantCust { get; set; }
        public double? SalInvcDGrntIntrmd { get; set; }
        public double? SalInvcDCoefficientintrmd { get; set; }
        public double? SalInvcDTotalGrantIntrmd { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalDisCount SalDisCountNavigation { get; set; }
        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
    }
}
