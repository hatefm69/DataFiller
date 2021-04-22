using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurPayPaperD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurPayPaperDSi { get; set; }
        public int? PurPayPaperHSi { get; set; }
        public int? PurReqstHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PurPayPaperDQty { get; set; }
        public double? PurPayPaperDPrice { get; set; }
        public double? PurPayPaperDTotal { get; set; }
    }
}
