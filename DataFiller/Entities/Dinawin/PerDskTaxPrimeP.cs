using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerDskTaxPrimeP : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerDskTaxPrimePSi { get; set; }
        public string PerDskTaxPrimePCu { get; set; }
        public string PerDskTaxPrimePTp { get; set; }
        public string Description { get; set; }
    }
}
