using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwKpurRqstD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRqstDSi { get; set; }
        public int? PurRqstHSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurRqstDQty { get; set; }
        public DateTime? PurRqstDDt { get; set; }
        public string PurRqstHCu { get; set; }
        public string PurRqstHTp { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public string CuProject { get; set; }
        public string CuCost { get; set; }
        public string TpProject { get; set; }
        public string TpCost { get; set; }
        public int? InvGdsSi { get; set; }
        public string PerName { get; set; }
        public string CtbOrgDepTp { get; set; }
        public double? PurRqstDQtyInv { get; set; }
        public string PurRqstDDrftNo { get; set; }
        public DateTime? PurRqstDDrftDate { get; set; }
        public byte? PurRqstDPurKind { get; set; }
        public string PurRqstHOfficial { get; set; }
        public byte? PurRqstHOffNext { get; set; }
    }
}
