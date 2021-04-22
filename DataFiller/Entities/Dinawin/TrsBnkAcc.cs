using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsBnkAcc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsBnkAccSi { get; set; }
        public int? TrsRsrcSi { get; set; }
        public int? SiAccM { get; set; }
        public double? TrsBnkAccPrc { get; set; }
        public double? TrsBnkAccPrcAcc { get; set; }
    }
}
