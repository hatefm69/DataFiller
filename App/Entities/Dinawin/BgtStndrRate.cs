using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtStndrRate : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtStndrRateSi { get; set; }
        public int InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public byte BgtStndrRateCoef { get; set; }
        public decimal BgtStndrRatePrice { get; set; }
    }
}
