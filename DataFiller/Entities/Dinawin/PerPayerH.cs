using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPayerH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPayerHSi { get; set; }
        public string PerPayerHCu { get; set; }
        public int? MmoadiType { get; set; }
    }
}
