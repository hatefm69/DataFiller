using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class گزارشمقایسهایی105خریدوفروشکالا : DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsIcratrTp { get; set; }
        public string InvUntTp { get; set; }
        public double? Qty102 { get; set; }
        public double? Qty214 { get; set; }
        public double? Qty114 { get; set; }
        public double InvGdsQtyReal { get; set; }
        public decimal? DclPrc { get; set; }
    }
}
