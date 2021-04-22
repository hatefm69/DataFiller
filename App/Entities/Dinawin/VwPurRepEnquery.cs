using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurRepEnquery: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public string PurOrderHTp { get; set; }
        public int? PurOrderHKindOrd { get; set; }
        public int? PurOrderHProcess { get; set; }
        public int? PurRespSi { get; set; }
        public bool? PurOrderHOk { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDDt { get; set; }
        public int PurReqstHSi { get; set; }
        public int? PurReqstHCu { get; set; }
        public int PurOrderHSi { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrSi { get; set; }
        public string PurRespCu { get; set; }
        public string PurRespTp { get; set; }
    }
}
