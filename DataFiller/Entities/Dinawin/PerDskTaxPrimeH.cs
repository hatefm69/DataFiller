using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerDskTaxPrimeH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerDskTaxPrimeHSi { get; set; }
        public string PerDskTaxPrimeHCu { get; set; }
        public string PerDskTaxPrimeHTp { get; set; }
        public string Description { get; set; }
    }
}
