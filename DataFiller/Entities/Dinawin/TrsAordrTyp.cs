using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAordrTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsAordrTyp()
        {
            TrsAordr = new HashSet<TrsAordr>();
        }

        public int TrsAordrTypSi { get; set; }
        public string TrsAordrTypTp { get; set; }

        public virtual ICollection<TrsAordr> TrsAordr { get; set; }
    }
}
