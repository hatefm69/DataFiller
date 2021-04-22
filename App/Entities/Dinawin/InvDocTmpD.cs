using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocTmpD : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDocTmpD()
        {
            InvDocD = new HashSet<InvDocD>();
        }

        public int InvDocTmpDSi { get; set; }
        public int InvDocTmpHSi { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public double? InvDocTmpDQty { get; set; }
        public decimal? InvDocTmpDPrice { get; set; }
        public decimal? InvDocTmpDTotal { get; set; }
        public string InvDocTmpDTp { get; set; }
        public double? InvDocTmpDQtyAccept { get; set; }
        public double? InvDocTmpDQtyreturn { get; set; }
        public decimal? InvDocTmpDPriceC { get; set; }
        public decimal? InvDocTmpDTotalC { get; set; }
        public double? ExchangeRate { get; set; }
        public int? CtbCurncySi { get; set; }
        public string InvDocTmpDExpNo { get; set; }
        public int? InvCostQcSi { get; set; }
        public bool? InvDevoteQc { get; set; }
        public int? PurchaseRequestId { get; set; }
        public double? InvDocTmpDQtyInv { get; set; }
        public int? PurchaseSendDetailId { get; set; }
        public double? Remain { get; set; }
        public DateTime? InvDocTmpDExpirDateM { get; set; }

        public virtual InvDocTmpH InvDocTmpHSiNavigation { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
    }
}
