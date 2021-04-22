using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRetInvcD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRetInvcDSi { get; set; }
        public int SalRetInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? SalRetInvcDRow { get; set; }
        public double SalRetInvcDQty { get; set; }
        public double? SalRetInvcDQty2 { get; set; }
        public decimal SalRetInvcDUntPrc { get; set; }
        public decimal SalRetInvcDTotal { get; set; }
        public string SalRetInvcDTp { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalOprInc { get; set; }
        public decimal? SalOprDec { get; set; }
        public decimal? SalRetInvCdSumTotal { get; set; }
        public decimal? SalretInvcDPrcDec { get; set; }
        public decimal? SalretInvcDPrcInc { get; set; }
        public bool? SalRetInvcDGiftOk { get; set; }
        public double? SalRetInvcDUntPrcC { get; set; }
        public decimal? SalRetInvcDTotalC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public decimal? SalretInvcDPrcDec2 { get; set; }
        public decimal? SalretInvcDPrcInc2 { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalRetInvcDSumPrcDec { get; set; }
        public double? SalRetInvcDSumPrcInc { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public decimal? SalretInvcDPrcDec3 { get; set; }
        public decimal? SalretInvcDPrcInc3 { get; set; }
        public string BatchNumberD { get; set; }
        public DateTime? SalRetInvcDExpiredate { get; set; }
        public double? Remain { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalRetInvcH SalRetInvcHSiNavigation { get; set; }
    }
}
