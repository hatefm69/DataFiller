using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsRsrcTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsRsrcTyp()
        {
            TrsRsrc = new HashSet<TrsRsrc>();
        }

        public int TrsRsrcTypSi { get; set; }
        public string TrsRsrcTypTp { get; set; }

        public virtual ICollection<TrsRsrc> TrsRsrc { get; set; }
    }
}
