using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcSrvD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcSrvDSi { get; set; }
        public int SalInvcSrvHSi { get; set; }
        public int SalSrvSi { get; set; }
        public int? SalInvcSrvDRow { get; set; }
        public double SalInvcSrvDQty { get; set; }
        public decimal SalInvcSrvDUntPrc { get; set; }
        public decimal SalInvcSrvDTotal { get; set; }
        public string SalInvcSrvDTp { get; set; }
        public decimal? SalInvcSrvDSumTotal { get; set; }
        public decimal? SalInvcSrvDPrcDec { get; set; }
        public decimal? SalInvcSrvDPrcInc { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalInvcSrvDPrcDec2 { get; set; }
        public double? SalInvcSrvDPrcInc2 { get; set; }
        public double? SalInvcSrvDSumPrcDec { get; set; }
        public double? SalInvcSrvDSumPrcInc { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalInvcSrvDPrcDec3 { get; set; }
        public double? SalInvcSrvDPrcInc3 { get; set; }
        public bool? SalInvcSrvDGiftOk { get; set; }
        public decimal? SalInvcSrvDTotalC { get; set; }
        public string BatchNumberD { get; set; }

        public virtual SalInvcSrvH SalInvcSrvHSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalSrv SalSrvSiNavigation { get; set; }
    }
}
