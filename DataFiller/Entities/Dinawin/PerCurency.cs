using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerCurency : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerCurencySi { get; set; }
        public string PerCurencyCu { get; set; }
        public string PerCurencyTp { get; set; }
    }
}
