using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurInvcD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? PurInvcDRow { get; set; }
        public double PurInvcDQty { get; set; }
        public decimal PurInvcDUntPrc { get; set; }
        public decimal PurInvcDIncPrc { get; set; }
        public decimal PurInvcDDecPrc { get; set; }
        public decimal PurInvcDTotal { get; set; }
        public string PurInvcDTp { get; set; }
        public int? PurOrdrSi { get; set; }
        public DateTime? PurInvcHDt { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurRespSi { get; set; }
        public int? PurInvcHScu { get; set; }
        public DateTime? PurInvcHSdt { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string PurRespCu { get; set; }
        public string PurRespTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public int? PurRqstHSi { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public int? InvDocHSi { get; set; }
        public DateTime? InvDocHDt { get; set; }
    }
}
