using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwpurPreInvcD: DinawinBaseEntity, IMyEntityDinawin
    {
        public double? PurPreInvcDQty { get; set; }
        public decimal? PurPreInvcDPrice { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurReqstHCu { get; set; }
        public int? PurPreInvcHSi { get; set; }
        public int? PurPreInvcDSi { get; set; }
        public int PurOrderDSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public int? PurReqstHDeliverst { get; set; }
        public string PurRqstCuseTp { get; set; }
        public string InvInvtTp { get; set; }
        public string InvInvtCu { get; set; }
        public DateTime? PurPreVinvcHDt { get; set; }
        public DateTime? PurPreInvcHDtactive { get; set; }
        public string PurPreInvcHCu { get; set; }
        public bool? PurPreInvcHHaveFile { get; set; }
        public bool? PurPreInvcHCancelled { get; set; }
        public string PurPreInvcDDesc { get; set; }
    }
}
