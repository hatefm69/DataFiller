using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalInvcH()
        {
            InvDocH = new HashSet<InvDocH>();
            SalDocVchr = new HashSet<SalDocVchr>();
            SalInvcAttach = new HashSet<SalInvcAttach>();
            SalInvcD = new HashSet<SalInvcD>();
            SalInvcDsrl = new HashSet<SalInvcDsrl>();
            SalInvcOpr = new HashSet<SalInvcOpr>();
            SalRetInvcH = new HashSet<SalRetInvcH>();
        }

        public int SalInvcHSi { get; set; }
        public int? SalInvcHCu { get; set; }
        public int? SalInvcHCu2 { get; set; }
        public string SalInvcHDs { get; set; }
        public string SalInvcHTp { get; set; }
        public short SalInvcHRfrncTyp { get; set; }
        public string SalInvcHReference { get; set; }
        public string SalInvcHDlvLoc { get; set; }
        public string SalInvcHRcvMthd { get; set; }
        public decimal SalInvcHPrcSumTotal { get; set; }
        public decimal? SalInvcHPrcSumTotalC { get; set; }
        public decimal SalInvcHPrcInc { get; set; }
        public decimal SalInvcHPrcDec { get; set; }
        public decimal SalInvcHPrcTotal { get; set; }
        public bool? SalInvcHCancelled { get; set; }
        public bool? SalInvcHAccDoc { get; set; }
        public bool? SalInvcHPrcRcvd { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InvDocHAccMSi { get; set; }
        public string SalInvcHStmpCus { get; set; }
        public DateTime? SalInvcHStmpCdt { get; set; }
        public string SalInvcHStmpMus { get; set; }
        public DateTime? SalInvcHStmpMdt { get; set; }
        public string SalCntrctSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public bool? SalInvcHLock { get; set; }
        public int? Salprint { get; set; }
        public int? SalContractHSi { get; set; }
        public decimal? SalInvcHGiftTotal { get; set; }
        public int? SalCancleSi { get; set; }
        public int? SalGiftInvGdsSi { get; set; }
        public decimal? SalInvcHPrcGift { get; set; }
        public int? SalExportPrmHSi { get; set; }
        public DateTime? SalInvcHDm { get; set; }
        public decimal? SalInvcHPrcInc2 { get; set; }
        public decimal? SalInvcHPrcDec2 { get; set; }
        public int? SalPreinvcHSi { get; set; }
        public double? SalInvcHPrcSumQty { get; set; }
        public int? SalCashiorSi { get; set; }
        public string BarNumber { get; set; }
        public string DescDriver { get; set; }
        public int? SalInvcHGood { get; set; }
        public string SalInvcHPrcRcvdDt { get; set; }
        public double? SalInvcHIntrmdPrc { get; set; }
        public string SalInvcHBarNo { get; set; }
        public string SalInvcHDriverName { get; set; }
        public int? SalDriverSi { get; set; }
        public int? ErpsystemId { get; set; }
        public int? ErpreferenceIdentityId { get; set; }
        public string SalinvcHCarNo { get; set; }
        public string SalInvcHPostCode { get; set; }
        public string SalInvcHCodeSharestan { get; set; }
        public string SalInvcHTel { get; set; }
        public string SalInvcHAddrsPur { get; set; }
        public string SalInvcHNamePur { get; set; }
        public string SalInvcHIno { get; set; }
        public string SalInvcHNationalCode { get; set; }
        public string SalInvcHFamilyPur { get; set; }
        public int? SiAccM { get; set; }
        public double? SalInvcHSumIntrmdPrc { get; set; }
        public int? SalvarietySi { get; set; }
        public bool? SalInvcHTrnsferDb { get; set; }
        public double? Remain { get; set; }
        public double? SalInvcHSumGrantCust { get; set; }
        public double? SalInvcHSumGrantIntrmd { get; set; }
        public string SalInvcHStmpTime { get; set; }
        public string SalInvcHStmpTimeEdit { get; set; }
        public int? SiCost { get; set; }

        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCntrct SalCntrctSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalDlvrr SalDlvrrSiNavigation { get; set; }
        public virtual SalDrvr SalDrvrSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual SalResp SalRespSiNavigation { get; set; }
        public virtual ICollection<InvDocH> InvDocH { get; set; }
        public virtual ICollection<SalDocVchr> SalDocVchr { get; set; }
        public virtual ICollection<SalInvcAttach> SalInvcAttach { get; set; }
        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
        public virtual ICollection<SalInvcDsrl> SalInvcDsrl { get; set; }
        public virtual ICollection<SalInvcOpr> SalInvcOpr { get; set; }
        public virtual ICollection<SalRetInvcH> SalRetInvcH { get; set; }
    }
}
