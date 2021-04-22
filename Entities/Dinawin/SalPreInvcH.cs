using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalPreInvcH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalPreInvcH()
        {
            SalExportPrmH = new HashSet<SalExportPrmH>();
            SalPreInvcAttach = new HashSet<SalPreInvcAttach>();
            SalPreInvcD = new HashSet<SalPreInvcD>();
            SalPreInvcOpr = new HashSet<SalPreInvcOpr>();
        }

        public int SalPreInvcHSi { get; set; }
        public int? SalPreInvcHCu { get; set; }
        public string SalPreInvcHDs { get; set; }
        public string SalPreInvcHTp { get; set; }
        public short SalPreInvcHRfrncTyp { get; set; }
        public string SalPreInvcHReference { get; set; }
        public string SalPreInvcHDlvLoc { get; set; }
        public string SalPreInvcHRcvMthd { get; set; }
        public decimal SalPreInvcHPrcSumTotal { get; set; }
        public decimal? SalPreInvcHPrcSumTotalC { get; set; }
        public decimal SalPreInvcHPrcInc { get; set; }
        public decimal SalPreInvcHPrcDec { get; set; }
        public decimal SalPreInvcHPrcTotal { get; set; }
        public byte SalPreInvcHStatus { get; set; }
        public short? SalPreInvcHExprTime { get; set; }
        public string SalPreInvcHExprDate { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public int? InvInvtSi { get; set; }
        public bool? SalPreInvcHLock { get; set; }
        public string SalPreInvcHStmpCus { get; set; }
        public DateTime? SalPreInvcHStmpCdt { get; set; }
        public string SalPreInvcHStmpMus { get; set; }
        public DateTime? SalPreInvcHStmpMdt { get; set; }
        public int? SalGiftInvGdsSi { get; set; }
        public double? SalPreInvcHGiftTotal { get; set; }
        public double? SalPreInvcHPrcGift { get; set; }
        public DateTime? SalPreInvcHDm { get; set; }
        public decimal? SalPreInvcHPrcInc2 { get; set; }
        public decimal? SalPreInvcHPrcDec2 { get; set; }
        public int? SalPreInvcHCu2 { get; set; }
        public decimal? SalExportPrmHPrcSumtotalC { get; set; }
        public double? SalPreInvcHPrcSumQty { get; set; }
        public int? SalPreprint { get; set; }
        public int? SalpreinvchSndInv { get; set; }
        public int? InvDocHAccMSi { get; set; }
        public string BatchNumberH { get; set; }
        public int? SalPreInvcHGood { get; set; }
        public string DescDriver { get; set; }
        public string SalPreInvcHBarNo { get; set; }
        public string SalPreInvcHDriverName { get; set; }
        public int? SalDriverSi { get; set; }
        public int? Salprint { get; set; }
        public int? SalePreInvoiceId { get; set; }
        public int? SiAccM { get; set; }
        public int? SalvarietySi { get; set; }
        public double? Remain { get; set; }
        public double? SalPreInvcHSumGrantCust { get; set; }
        public double? SalPreInvcHSumGrantIntrmd { get; set; }
        public int? SalpreInvcHRunNum { get; set; }
        public bool? SalpreInvcHRunNumAccept { get; set; }
        public int? SalpreInvcHIno { get; set; }
        public byte[] SignImage { get; set; }
        public string SalPreInvcHStmpTime { get; set; }
        public string SalPreInvcHStmpTimeEdit { get; set; }
        public int? SalRequestHSi { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalDlvrr SalDlvrrSiNavigation { get; set; }
        public virtual SalDrvr SalDrvrSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual SalResp SalRespSiNavigation { get; set; }
        public virtual ICollection<SalExportPrmH> SalExportPrmH { get; set; }
        public virtual ICollection<SalPreInvcAttach> SalPreInvcAttach { get; set; }
        public virtual ICollection<SalPreInvcD> SalPreInvcD { get; set; }
        public virtual ICollection<SalPreInvcOpr> SalPreInvcOpr { get; set; }
    }
}
