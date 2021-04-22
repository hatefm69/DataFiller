using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAordr : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsAordr()
        {
            TrsDcC = new HashSet<TrsDcC>();
        }

        public int TrsAordrSi { get; set; }
        public DateTime TrsAordrDt { get; set; }
        public int? TrsAordrTypSi { get; set; }
        public decimal? TrsAordrPrc { get; set; }
        public string TrsAordrDesc { get; set; }
        public int? TrsArqstSi { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }

        public virtual TrsAordrTyp TrsAordrTypSiNavigation { get; set; }
        public virtual ICollection<TrsDcC> TrsDcC { get; set; }
    }
}
