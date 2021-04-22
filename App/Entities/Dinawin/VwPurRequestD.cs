using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurRequestD: DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDDt { get; set; }
        public int PurReqstHSi { get; set; }
        public int? PurReqstHCu { get; set; }
        public int? PurReqstHApplyer { get; set; }
        public string PurBuyStCu { get; set; }
        public int PurReqstDSi { get; set; }
        public bool? PurReqstHOk { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PurReqstHDeliverst { get; set; }
        public byte? PurReqstHSts { get; set; }
        public int? PurOrderDSi { get; set; }
        public int InvUntSi { get; set; }
        public int? PurReqstHBuyKind { get; set; }
        public int? PurReqstHProcess { get; set; }
        public int? PurReqstHKindOrd { get; set; }
        public int? PurRespSi { get; set; }
        public int? PurRqstCuseSi { get; set; }
        public string PurRqstCuseTp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
    }
}
