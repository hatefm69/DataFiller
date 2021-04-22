using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerExempt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerExemptSi { get; set; }
        public string PerExemptCu { get; set; }
        public string PerExemptTp { get; set; }
    }
}
