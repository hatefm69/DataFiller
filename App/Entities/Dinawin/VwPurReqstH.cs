using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurReqstH: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurReqstHSi { get; set; }
        public int? PurReqstHCu { get; set; }
        public DateTime? PurReqstHDt { get; set; }
        public string PurReqstHTp { get; set; }
        public string PurReqstHDocno { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public int? PurReqstHApplyer { get; set; }
        public int? PurReqstHDeliverst { get; set; }
        public int? PurRqstCuseSi { get; set; }
        public string PurRqstCuseTp { get; set; }
        public bool? PurReqstHOk { get; set; }
        public byte? PurReqstHSts { get; set; }
        public int? PurReqstHBuyKind { get; set; }
        public int? PurReqstHProcess { get; set; }
        public int? PurReqstHKindOrd { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PurReqstDDt { get; set; }
        public int? InvInvtSi { get; set; }
        public int? SiCost { get; set; }
        public int? PurReqstDUsage { get; set; }
        public string CuCostD { get; set; }
        public string TpCostD { get; set; }
        public int? SiCostD { get; set; }
        public int? PurReqProcSi { get; set; }
        public string PurReqProcTp { get; set; }
        public int? PurOrdPayKindSi { get; set; }
        public string PurOrdPayKindTp { get; set; }
        public int? PurBuyStSi { get; set; }
        public string PurBuyStCu { get; set; }
        public int? PurRespSi { get; set; }
        public string PurReqTypTp { get; set; }
        public string PurRespTp { get; set; }
    }
}
