using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDscr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDscrSi { get; set; }
        public string TrsDscrTp { get; set; }
        public string TrsDscrTp2 { get; set; }
    }
}
