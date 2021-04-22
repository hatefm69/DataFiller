using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsArqstSts : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsArqstSts()
        {
            TrsArqst = new HashSet<TrsArqst>();
        }

        public int TrsArqstStsSi { get; set; }
        public string TrsArqstStsTp { get; set; }

        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
    }
}
