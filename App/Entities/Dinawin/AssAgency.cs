using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssAgency : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssAgency()
        {
            AssReceiptH = new HashSet<AssReceiptH>();
        }

        public int AssAgencySi { get; set; }
        public int? AssAgencyCu { get; set; }
        public string AssAgencyTp { get; set; }
        public string AssAgencyMng { get; set; }

        public virtual ICollection<AssReceiptH> AssReceiptH { get; set; }
    }
}
