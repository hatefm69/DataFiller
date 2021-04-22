using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcS : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsDcS()
        {
            TrsDcA = new HashSet<TrsDcA>();
        }

        public int TrsDcSSi { get; set; }
        public int TrsDcCSi { get; set; }
        public short TrsStsSi { get; set; }
        public DateTime TrsDcSDt { get; set; }
        public string TrsDcSTm { get; set; }
        public byte? CtbMnthSi { get; set; }
        public int? TrsDcSFirstCu { get; set; }

        public virtual CtbMnth CtbMnthSiNavigation { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
    }
}
