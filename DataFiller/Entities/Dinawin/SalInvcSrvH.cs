using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcSrvH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalInvcSrvH()
        {
            SalInvcSrvD = new HashSet<SalInvcSrvD>();
            SalInvcSrvOpr = new HashSet<SalInvcSrvOpr>();
        }

        public int SalInvcSrvHSi { get; set; }
        public int? SalInvcSrvHCu { get; set; }
        public int? SalInvcSrvHCu2 { get; set; }
        public string SalInvcSrvHDs { get; set; }
        public string SalInvcSrvHTp { get; set; }
        public decimal SalInvcSrvHPrcSumTotal { get; set; }
        public decimal SalInvcSrvHPrcInc { get; set; }
        public decimal SalInvcSrvHPrcDec { get; set; }
        public decimal SalInvcSrvHPrcTotal { get; set; }
        public bool SalInvcSrvHCancelled { get; set; }
        public bool SalInvcSrvHAccDoc { get; set; }
        public bool SalInvcSrvHPrcRcvd { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public string SalInvcSrvHStmpCus { get; set; }
        public DateTime? SalInvcSrvHStmpCdt { get; set; }
        public string SalInvcSrvHStmpMus { get; set; }
        public DateTime? SalInvcSrvHStmpMdt { get; set; }
        public short? SalInvcSrvHRfrncTyp { get; set; }
        public string SalInvcSrvHReference { get; set; }
        public bool? SalInvcSrvHLock { get; set; }
        public decimal? SalInvcSrvHPrcSumTotalC { get; set; }
        public double? SalInvcSrvHPrcSumQty { get; set; }
        public int? SalPreInvcSrvHSi { get; set; }
        public DateTime? SalInvcSrvHDm { get; set; }
        public string BatchNumberH { get; set; }
        public int? ErpsystemId { get; set; }
        public int? ErpreferenceIdentityId { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalDlvrr SalDlvrrSiNavigation { get; set; }
        public virtual SalDrvr SalDrvrSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual SalResp SalRespSiNavigation { get; set; }
        public virtual ICollection<SalInvcSrvD> SalInvcSrvD { get; set; }
        public virtual ICollection<SalInvcSrvOpr> SalInvcSrvOpr { get; set; }
    }
}
