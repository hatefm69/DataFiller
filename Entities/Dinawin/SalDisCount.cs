using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDisCount : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalDisCount()
        {
            SalInvcD = new HashSet<SalInvcD>();
        }

        public int SalDisCountId { get; set; }
        public string SalDisCountTx { get; set; }

        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
    }
}
