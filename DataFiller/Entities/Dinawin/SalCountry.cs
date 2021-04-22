using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCountry : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCountrySi { get; set; }
        public string SalCountryCu { get; set; }
        public string SalCountryTp { get; set; }
    }
}
