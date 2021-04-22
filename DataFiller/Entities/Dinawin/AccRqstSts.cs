using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccRqstSts : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccRqstSts()
        {
            AccArqst = new HashSet<AccArqst>();
        }

        public int AccRqstStsSi { get; set; }
        public string AccRqstStsTp { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
    }
}
