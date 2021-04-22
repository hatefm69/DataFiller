using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalProvince : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalProvince()
        {
            SalCity = new HashSet<SalCity>();
        }

        public int SalProvinceSi { get; set; }
        public string SalProvinceCu { get; set; }
        public string SalProvinceTp { get; set; }
        public int? SalCountrySi { get; set; }

        public virtual ICollection<SalCity> SalCity { get; set; }
    }
}
