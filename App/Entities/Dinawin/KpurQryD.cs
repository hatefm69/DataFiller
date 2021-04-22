using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurQryD : DinawinBaseEntity, IMyEntityDinawin
    {
        public decimal? KpurqryDPrc { get; set; }
        public int? PurQrySi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PurRqstDQty { get; set; }
    }
}
