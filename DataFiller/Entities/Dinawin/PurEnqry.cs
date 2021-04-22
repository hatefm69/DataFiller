using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurEnqry : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurEnqrySi { get; set; }
        public int PurVndrSi { get; set; }
        public int InvGdsSi { get; set; }
        public int PurRespSi { get; set; }
        public DateTime? PurEnqryDt { get; set; }
        public decimal? PurEnqryUntPrc { get; set; }
        public string PurEnqryTp { get; set; }
        public int? PurOrdrSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PurOrdr PurOrdrSiNavigation { get; set; }
        public virtual PurVndr PurVndrSiNavigation { get; set; }
    }
}
