using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalAdjustment : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalAdjustmentSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalAdjustmentCu { get; set; }
        public string SalAdjustmentTp { get; set; }
    }
}
