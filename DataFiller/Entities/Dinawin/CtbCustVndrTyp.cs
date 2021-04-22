using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbCustVndrTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbCustVndrTyp()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int CtbCustVndrTypSi { get; set; }
        public string CtbCustVndrTypTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}
