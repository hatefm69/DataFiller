using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurEnqry: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurEnqrySi { get; set; }
        public int PurVndrSi { get; set; }
        public int InvGdsSi { get; set; }
        public int PurRespSi { get; set; }
        public DateTime? PurEnqryDt { get; set; }
        public decimal? PurEnqryUntPrc { get; set; }
        public string PurEnqryTp { get; set; }
        public int? PurOrdrSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrGrpSi { get; set; }
        public string PurVndrGrpCu { get; set; }
        public string PurVndrGrpTp { get; set; }
        public string PurRespCu { get; set; }
        public string PurRespTp { get; set; }
    }
}
