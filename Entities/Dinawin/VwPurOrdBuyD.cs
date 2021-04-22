using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurOrdBuyD: DinawinBaseEntity, IMyEntityDinawin
    {
        public decimal? PurPreInvcDPrice { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public int PurOrderHSi { get; set; }
        public int? PurPreInvcDSi { get; set; }
        public int PurOrdBuyDSi { get; set; }
        public int? PurOrdBuyHSi { get; set; }
        public int? PurBuyDSi { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurReqstHCu { get; set; }
        public string PurPreInvcHCu { get; set; }
        public DateTime? PurPreVinvcHDt { get; set; }
        public string PurOrdBuyHCu { get; set; }
        public DateTime? PurOrdBuyHDt { get; set; }
        public int PurVndrSi { get; set; }
        public int PurOrdVndrSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public string InvInvtTp { get; set; }
        public int? InvInvtSi { get; set; }
    }
}
