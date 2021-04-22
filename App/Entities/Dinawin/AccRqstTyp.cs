using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccRqstTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccRqstTyp()
        {
            AccArqst = new HashSet<AccArqst>();
        }

        public int AccRqstTypSi { get; set; }
        public string AccRqstTypTp { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
    }
}
