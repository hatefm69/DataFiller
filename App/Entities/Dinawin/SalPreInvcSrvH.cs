using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalPreInvcSrvH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalPreInvcSrvH()
        {
            SalPreInvcSrvD = new HashSet<SalPreInvcSrvD>();
            SalPreInvcSrvOpr = new HashSet<SalPreInvcSrvOpr>();
        }

        public int SalPreInvcSrvHSi { get; set; }
        public int? SalPreInvcSrvHCu { get; set; }
        public string SalPreInvcSrvHDs { get; set; }
        public string SalPreInvcSrvHTp { get; set; }
        public short SalPreInvcSrvHRfrncTyp { get; set; }
        public string SalPreInvcSrvHReference { get; set; }
        public string SalPreInvcSrvHDlvLoc { get; set; }
        public string SalPreInvcSrvHRcvMthd { get; set; }
        public decimal SalPreInvcSrvHPrcSumTotal { get; set; }
        public decimal SalPreInvcSrvHPrcInc { get; set; }
        public decimal SalPreInvcSrvHPrcDec { get; set; }
        public decimal SalPreInvcSrvHPrcTotal { get; set; }
        public byte SalPreInvcSrvHStatus { get; set; }
        public short? SalPreInvcSrvHExprTime { get; set; }
        public string SalPreInvcSrvHExprDate { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalInvcSrvHSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public int? SalPrint1 { get; set; }
        public string SalPreInvcSrvHStmpCus { get; set; }
        public DateTime? SalPreInvcSrvHStmpCdt { get; set; }
        public string SalPreInvcSrvHStmpMus { get; set; }
        public DateTime? SalPreInvcSrvHStmpMdt { get; set; }
        public bool? SalPreInvcSrvHLock { get; set; }
        public int? SalPreInvcSrvHPrcSumQty { get; set; }
        public DateTime? SalPreInvcSrvHDm { get; set; }
        public string BatchNumberH { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalDlvrr SalDlvrrSiNavigation { get; set; }
        public virtual SalDrvr SalDrvrSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual SalResp SalRespSiNavigation { get; set; }
        public virtual ICollection<SalPreInvcSrvD> SalPreInvcSrvD { get; set; }
        public virtual ICollection<SalPreInvcSrvOpr> SalPreInvcSrvOpr { get; set; }
    }
}
