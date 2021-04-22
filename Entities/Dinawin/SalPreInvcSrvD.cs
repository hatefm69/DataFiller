using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalPreInvcSrvD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalPreInvcSrvDSi { get; set; }
        public int SalPreInvcSrvHSi { get; set; }
        public int SalSrvSi { get; set; }
        public int? SalPreInvcSrvDRow { get; set; }
        public double SalPreInvcSrvDQty { get; set; }
        public decimal SalPreInvcSrvDUntPrc { get; set; }
        public decimal SalPreInvcSrvDTotal { get; set; }
        public string SalPreInvcSrvDTp { get; set; }
        public int? InvUntSi { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalOprInc { get; set; }
        public decimal? SalOprDec { get; set; }
        public decimal? SalPreInvcSrvDSumTotal { get; set; }
        public decimal? SalPreInvcSrvDPrcDec { get; set; }
        public decimal? SalPreInvcSrvDPrcInc { get; set; }
        public int? SalOprSi2 { get; set; }
        public string SalOprTp2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public decimal? SalPreInvcSrvDPrcDec2 { get; set; }
        public decimal? SalPreInvcSrvDPrcInc2 { get; set; }
        public decimal? SalPreInvcSrvDSumPrcInc { get; set; }
        public decimal? SalPreInvcSrvDSumPrcDec { get; set; }
        public int? SalOprSi3 { get; set; }
        public string SalOprTp3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public decimal? SalPreInvcSrvDPrcDec3 { get; set; }
        public decimal? SalPreInvcSrvDPrcInc3 { get; set; }
        public string BatchNumberD { get; set; }

        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalOpr SalOprSiNavigation { get; set; }
        public virtual SalPreInvcSrvH SalPreInvcSrvHSiNavigation { get; set; }
        public virtual SalSrv SalSrvSiNavigation { get; set; }
    }
}
