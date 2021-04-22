using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCustActiveTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCustActiveTyp()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalCustActiveTypSi { get; set; }
        public string SalCustActiveTypTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
