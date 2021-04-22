using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocTmpH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDocTmpH()
        {
            InvDocTmpD = new HashSet<InvDocTmpD>();
            InvDocTmpHattach = new HashSet<InvDocTmpHattach>();
        }

        public int InvDocTmpHSi { get; set; }
        public int? InvDocTmpHCu { get; set; }
        public string InvDocTmpHDs { get; set; }
        public int? InvInvtSi { get; set; }
        public int? PurVndrSi { get; set; }
        public string InvDocTmpHTp { get; set; }
        public bool? InvDocTmpHSentDoc { get; set; }
        public int? SiSystem { get; set; }
        public int? RowSi { get; set; }
        public string InvDocTmpHCu2 { get; set; }
        public DateTime? InvDocTmpHDm { get; set; }
        public string InvDocTmpHStmpCus { get; set; }
        public byte? InvDocTmpHSts { get; set; }
        public string InvDocTmpHExpNo { get; set; }
        public string InvDocTmpHReference { get; set; }
        public int? PurOrdBuyHSi { get; set; }
        public string InvDocTmpHStmpTim { get; set; }
        public int? PurReqstHSi { get; set; }
        public byte? InvDocTmpHRef { get; set; }
        public int? PurchaseSendId { get; set; }
        public string InvDocTmpHLoginEdit { get; set; }
        public DateTime? InvDocTmpHDsEdit { get; set; }
        public string InvDocTmpHDlvBuy { get; set; }
        public string InvDocTmpHCarNo { get; set; }
        public string InvDocTmpHDlvLoc { get; set; }
        public string BarNumber { get; set; }
        public string DescDriver { get; set; }
        public int? SalDriverSi { get; set; }
        public int? InvDocHGood { get; set; }
        public int? InvTypSi { get; set; }
        public int? PerPrsnlSi2 { get; set; }
        public string InvDocTmpHPurName { get; set; }
        public int? InvRqstHSi { get; set; }
        public bool? InvDocTmpHLock { get; set; }

        public virtual ICollection<InvDocTmpD> InvDocTmpD { get; set; }
        public virtual ICollection<InvDocTmpHattach> InvDocTmpHattach { get; set; }
    }
}
