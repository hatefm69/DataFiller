using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurOrdBuyDsel: DinawinBaseEntity, IMyEntityDinawin
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
        public int PurVndrSi { get; set; }
        public int PurOrdBuyDSi { get; set; }
    }
}
