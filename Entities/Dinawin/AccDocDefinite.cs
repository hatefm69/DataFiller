using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccDocDefinite : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccDocDefinite()
        {
            AccHdoc = new HashSet<AccHdoc>();
        }

        public int SiDefinite { get; set; }
        public string LoginName { get; set; }
        public string TpDefinite { get; set; }
        public bool? EndLevel { get; set; }
        public int? LevelNo { get; set; }

        public virtual ICollection<AccHdoc> AccHdoc { get; set; }
    }
}
