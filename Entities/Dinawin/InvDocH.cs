using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDocH()
        {
            AssReceiptH = new HashSet<AssReceiptH>();
            InvDocD = new HashSet<InvDocD>();
            PurInvcD = new HashSet<PurInvcD>();
        }

        public int InvDocHSi { get; set; }
        public int? InvDocHCu { get; set; }
        public string InvDocHDs { get; set; }
        public int InvDocHRfrncTyp { get; set; }
        public string InvDocHReference { get; set; }
        public bool? InvDocHDefinite { get; set; }
        public byte InvDocHLevel { get; set; }
        public int InvDocTypSi { get; set; }
        public int InvInvtSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PerPersonnelSi { get; set; }
        public int? AccMSi { get; set; }
        public int? InvInvtSi2 { get; set; }
        public int? SalCustSi { get; set; }
        public string InvDocHTp { get; set; }
        public int? InvDocHSi2 { get; set; }
        public int? InvDocHSiParent { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? AccLmSiHdr { get; set; }
        public DateTime? InvDocHDm { get; set; }
        public int? SalRetInvcHSi { get; set; }
        public int? InvDocHCu2 { get; set; }
        public int? InvDocTmpHSi { get; set; }
        public int? InvVchrHId { get; set; }
        public int? SalExportPrmHSi { get; set; }
        public string InvDocHExpNo { get; set; }
        public int? SalPreinvcHSi { get; set; }
        public int? InvDocHSts { get; set; }
        public string InvDocHCuDoc { get; set; }
        public string InvDocHStmpCus { get; set; }
        public string InvDocHTp2 { get; set; }
        public decimal? InvDocHPrcInc { get; set; }
        public decimal? InvDocHPrcDec { get; set; }
        public int? SalDrvrSi { get; set; }
        public string BarNumber { get; set; }
        public string DescDriver { get; set; }
        public bool? TempDoc { get; set; }
        public string TpCreator { get; set; }
        public string LoginName { get; set; }
        public string InvStatus { get; set; }
        public int? InvDocDefinitSi { get; set; }
        public string InvDocHStsAcP107 { get; set; }
        public bool? InvDocHQc { get; set; }
        public bool? InvDocHPm { get; set; }
        public int? InvTypSi { get; set; }
        public int? InvDocHGood { get; set; }
        public int? InvControlGdsSi { get; set; }
        public int? InvExportPrmHSi { get; set; }
        public int? PerPrsnlSi1 { get; set; }
        public int? PerPrsnlSi2 { get; set; }
        public int? InvDocHReference2 { get; set; }
        public bool? InvDocHSentAcc { get; set; }
        public string InvDocHDlvLoc { get; set; }
        public string InvDocHDrivername { get; set; }
        public int? SalDriverSi { get; set; }
        public string InvDocHDlvBuy { get; set; }
        public string InvDocHCarNo { get; set; }
        public int? Invprint { get; set; }
        public string InvprintUser { get; set; }
        public int? PurchaseSendId { get; set; }
        public bool? SalFrom { get; set; }
        public DateTime? InvDocHStmpCdt { get; set; }
        public bool? InvDocHEstimatePrc { get; set; }
        public int? InvDocHSi214 { get; set; }
        public int? InvDocHSi104 { get; set; }
        public int? InvRqstHSi { get; set; }
        public int? SiAccM { get; set; }
        public bool? InvDocHTrnsferDb { get; set; }
        public string InvDocHTypeReceipte { get; set; }
        public string InvDocHPurName { get; set; }
        public int? SalTypSi { get; set; }
        public int? InvdeliverySi { get; set; }
        public int? InvDocTypSiParent { get; set; }
        public int? AccTSi { get; set; }
        public string InvDocHStmpTime { get; set; }
        public string InvDocHStmpTimeEdit { get; set; }
        public DateTime? InvDocHStmpMdt { get; set; }
        public int? SiCost { get; set; }
        public int? ProDocHSi { get; set; }

        public virtual InvDocTyp InvDocTypSiNavigation { get; set; }
        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual PurVndr PurVndrSiNavigation { get; set; }
        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
        public virtual ICollection<AssReceiptH> AssReceiptH { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<PurInvcD> PurInvcD { get; set; }
    }
}
