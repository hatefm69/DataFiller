using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocD : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDocD()
        {
            InvBatchNumber = new HashSet<InvBatchNumber>();
        }

        public int InvDocDSi { get; set; }
        public int InvDocHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public int? InvDocTmpDSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? CtbProjectSi { get; set; }
        public byte InvDocDstsSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public double InvDocDQty { get; set; }
        public double? InvDocDQty2 { get; set; }
        public decimal InvDocDPrice { get; set; }
        public decimal InvDocDTotal { get; set; }
        public string InvDocDTp { get; set; }
        public int? InvGdsTypSi { get; set; }
        public DateTime? InvDocDExpireDate { get; set; }
        public string InvDocDSerialKey { get; set; }
        public string InvDocDExpNo { get; set; }
        public decimal? InvDocDPriceC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public decimal? InvDocDTotalC { get; set; }
        public decimal? InvDocDPrice2 { get; set; }
        public int? SalExportPrmDSi { get; set; }
        public string InvDocDDesc { get; set; }
        public int? InvOprSi { get; set; }
        public string InvOprTp { get; set; }
        public double? InvOprDefaultValue { get; set; }
        public double? InvDocDPrcInc { get; set; }
        public double? InvDocDPrcDec { get; set; }
        public int? InvOprSi2 { get; set; }
        public string InvOprTp2 { get; set; }
        public double? InvOprDefaultValue2 { get; set; }
        public double? InvDocDPrcInc2 { get; set; }
        public double? InvDocDPrcDec2 { get; set; }
        public double? InvDocDSumTotal { get; set; }
        public decimal? InvDocDPriceBs { get; set; }
        public decimal? InvDocDPriceCbs { get; set; }
        public decimal? InvDocDTotalBs { get; set; }
        public decimal? InvDocDTotalCbs { get; set; }
        public int? InvDocDSiParent { get; set; }
        public int? InvDocRqstSi { get; set; }
        public int? InvOprSi3 { get; set; }
        public string InvOprTp3 { get; set; }
        public double? InvOprDefaultValue3 { get; set; }
        public double? InvDocDPrcInc3 { get; set; }
        public double? InvDocDPrcDec3 { get; set; }
        public int? InvControlGdsCu { get; set; }
        public double? InvDocDFinalCostPrice { get; set; }
        public DateTime? InvDocDExpirDateM { get; set; }
        public int? PurchaseRequestId { get; set; }
        public double? Remain { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? InvRqstDSi { get; set; }
        public bool? Isallotment { get; set; }
        public int? InvDocDSi2 { get; set; }
        public int? InvDocDRow { get; set; }

        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual CtbProject CtbProjectSiNavigation { get; set; }
        public virtual InvDocDsts InvDocDstsSiNavigation { get; set; }
        public virtual InvDocH InvDocHSiNavigation { get; set; }
        public virtual InvDocTmpD InvDocTmpDSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual ICollection<InvBatchNumber> InvBatchNumber { get; set; }
    }
}
