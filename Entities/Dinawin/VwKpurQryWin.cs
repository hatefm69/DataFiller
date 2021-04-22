using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwKpurQryWin: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvGdsSi { get; set; }
        public decimal? KpurqryDPrc { get; set; }
        public int? PurRqstHSi { get; set; }
        public double? PurRqstDQty { get; set; }
        public int PurQrySi { get; set; }
        public int PurRqstDSi { get; set; }
    }
}
