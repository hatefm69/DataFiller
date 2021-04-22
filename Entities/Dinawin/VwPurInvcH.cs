using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurInvcH: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurInvcHSi { get; set; }
        public DateTime PurInvcHDt { get; set; }
        public int PurVndrSi { get; set; }
        public int PurRespSi { get; set; }
        public int? PurInvcHScu { get; set; }
        public DateTime? PurInvcHSdt { get; set; }
        public string PurInvcHTp { get; set; }
        public decimal PurInvcHPrcTotal { get; set; }
        public bool PurInvcHAccDoc { get; set; }
        public string PurInvcHStmpCus { get; set; }
        public DateTime? PurInvcHStmpCdt { get; set; }
        public string PurInvcHStmpMus { get; set; }
        public DateTime? PurInvcHStmpMdt { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string PurRespCu { get; set; }
        public string PurRespTp { get; set; }
    }
}
