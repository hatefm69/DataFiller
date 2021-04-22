using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsStsTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsStsTyp()
        {
            TrsStsTypUsr = new HashSet<TrsStsTypUsr>();
        }

        public int TrsStsTypSi { get; set; }
        public string TrsStsTypTp { get; set; }

        public virtual ICollection<TrsStsTypUsr> TrsStsTypUsr { get; set; }
    }
}
