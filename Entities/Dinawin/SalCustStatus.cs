using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCustStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCustStatus()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalCustStatusSi { get; set; }
        public string SalCustStatusTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
