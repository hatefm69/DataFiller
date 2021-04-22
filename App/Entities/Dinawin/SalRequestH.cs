using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRequestH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalRequestH()
        {
            SalRequestD = new HashSet<SalRequestD>();
            SalRequestOpr = new HashSet<SalRequestOpr>();
        }

        public int SalRequestHSi { get; set; }
        public int? SalRequestHCu { get; set; }
        public string SalRequestHDs { get; set; }
        public string SalRequestHTp { get; set; }
        public short? SalRequestHRfrncTyp { get; set; }
        public string SalRequestHReference { get; set; }
        public string SalRequestHDlvLoc { get; set; }
        public string SalRequestHRcvMthd { get; set; }
        public decimal SalRequestHPrcSumTotal { get; set; }
        public decimal? SalRequestHPrcSumTotalC { get; set; }
        public decimal SalRequestHPrcInc { get; set; }
        public decimal SalRequestHPrcDec { get; set; }
        public decimal SalRequestHPrcTotal { get; set; }
        public byte SalRequestHStatus { get; set; }
        public short? SalRequestHExprTime { get; set; }
        public string SalRequestHExprDate { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public int? InvInvtSi { get; set; }
        public bool? SalRequestHLock { get; set; }
        public string SalRequestHStmpCus { get; set; }
        public DateTime? SalRequestHStmpCdt { get; set; }
        public string SalRequestHStmpMus { get; set; }
        public DateTime? SalRequestHStmpMdt { get; set; }
        public DateTime? SalRequestHDm { get; set; }
        public int? SalRequestHCu2 { get; set; }
        public double? SalRequestHPrcSumQty { get; set; }
        public int? SalPreprint { get; set; }
        public string BatchNumberH { get; set; }
        public string DescDriver { get; set; }
        public string SalRequestHBarNo { get; set; }
        public string SalRequestHDriverName { get; set; }
        public int? SalDriverSi { get; set; }
        public int? SalvarietySi { get; set; }
        public string SalRequestHStmpTime { get; set; }
        public string SalRequestHStmpTimeEdit { get; set; }
        public double? SalRequestHPrcGift { get; set; }
        public int? SalPreInvcHSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalRequestHGood { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalDlvrr SalDlvrrSiNavigation { get; set; }
        public virtual SalDrvr SalDrvrSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual SalResp SalRespSiNavigation { get; set; }
        public virtual ICollection<SalRequestD> SalRequestD { get; set; }
        public virtual ICollection<SalRequestOpr> SalRequestOpr { get; set; }
    }
}
