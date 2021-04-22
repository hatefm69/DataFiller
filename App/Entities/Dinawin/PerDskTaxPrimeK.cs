using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerDskTaxPrimeK : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerDskTaxPrimeKSi { get; set; }
        public string PerDskTaxPrimeKCu { get; set; }
        public string PerDskTaxPrimeKTp { get; set; }
        public string Description { get; set; }
    }
}
