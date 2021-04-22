using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsArqstTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsArqstTyp()
        {
            TrsArqst = new HashSet<TrsArqst>();
        }

        public int TrsArqstTypSi { get; set; }
        public string TrsArqstTypTp { get; set; }

        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
    }
}
