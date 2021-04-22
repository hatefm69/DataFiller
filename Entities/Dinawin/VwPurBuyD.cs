using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurBuyD: DinawinBaseEntity, IMyEntityDinawin
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
        public int? PurBuyHSi { get; set; }
        public double? PurBuyDPrice { get; set; }
        public double? PurBuyDQty { get; set; }
        public int PurBuyDSi { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurReqstHCu { get; set; }
        public double? PurPreInvcDQty { get; set; }
        public DateTime? PurBuyHDt { get; set; }
        public string PurBuyHCu { get; set; }
        public int? InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public int PurVndrSi { get; set; }
    }
}
