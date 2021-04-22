using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurOrderD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurOrderDSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurReqstHCu { get; set; }
        public int? PurReqstHApplyer { get; set; }
        public string PurBuyStCu { get; set; }
        public int? PurReqstDSi { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurOrdBuyDSi { get; set; }
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public int? PurOrderHProcess { get; set; }
        public int? PurOrderHKindOrd { get; set; }
        public int? PurBuyDSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public string PurReqstHBuyKind { get; set; }
        public string PurReqstHProcess { get; set; }
        public string PurReqstHKindOrd { get; set; }
        public int? PurRespSi { get; set; }
        public string PurRespTp { get; set; }
        public int? PurReqstHDeliverst { get; set; }
        public string PurRqstCuseTp { get; set; }
        public int? PurRqstCuseSi { get; set; }
        public string InvInvtTp { get; set; }
        public string InvInvtCu { get; set; }
        public int? PurOrderHPayer { get; set; }
        public int? PurOrderHPayKind { get; set; }
        public string PurOrdPayerTp { get; set; }
        public string PurOrdPayKindTp { get; set; }
        public int? PurReqstHSi { get; set; }
        public int? PurReqstHProcessSi { get; set; }
    }
}
