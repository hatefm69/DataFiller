using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssVchrH()
        {
            AssVchrD = new HashSet<AssVchrD>();
        }

        public int AssVchrHId { get; set; }
        public DateTime? AssVchrHDate { get; set; }
        public DateTime? AssVchrHDateFrom { get; set; }
        public DateTime? AssVchrHDateUntil { get; set; }
        public string AssVchrHTx { get; set; }
        public bool? AssVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? AssVchrHRow { get; set; }

        public virtual ICollection<AssVchrD> AssVchrD { get; set; }
    }
}
