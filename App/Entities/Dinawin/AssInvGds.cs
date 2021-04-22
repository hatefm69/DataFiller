using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssInvGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssInvGds()
        {
            AssServiceD = new HashSet<AssServiceD>();
        }

        public int AssInvGdsSi { get; set; }
        public string AssInvGdsCu { get; set; }
        public string AssInvGdsTp { get; set; }
        public string AssInvGdsNo { get; set; }
        public int AssInvGdsStock { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual ICollection<AssServiceD> AssServiceD { get; set; }
    }
}
