using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRequestD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRequestDSi { get; set; }
        public int SalRequestHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? SalRequestDRow { get; set; }
        public double SalRequestDQty { get; set; }
        public double? SalRequestDQty2 { get; set; }
        public decimal SalRequestDUntPrc { get; set; }
        public decimal SalRequestDTotal { get; set; }
        public string SalRequestDTp { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalOprInc { get; set; }
        public decimal? SalOprDec { get; set; }
        public decimal? SalRequestDPrcDec { get; set; }
        public decimal? SalRequestDPrcInc { get; set; }
        public decimal? SalRequestDSumTotal { get; set; }
        public bool? SalRequestDGiftOk { get; set; }
        public double? SalRequestDTotalC { get; set; }
        public double? SalRequestDUntPrcC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public decimal? SalRequestDPrcInc2 { get; set; }
        public decimal? SalRequestDPrcDec2 { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalRequestDSumPrcDec { get; set; }
        public double? SalRequestDSumPrcInc { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalRequestDPrcInc3 { get; set; }
        public double? SalRequestDPrcDec3 { get; set; }
        public string BatchNumberD { get; set; }
        public string InvBatchNumberCode { get; set; }
        public DateTime? SalRequestDExpiredate { get; set; }
        public double? Remain { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalRequestH SalRequestHSiNavigation { get; set; }
    }
}
