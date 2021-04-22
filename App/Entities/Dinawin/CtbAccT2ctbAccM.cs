using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccT2ctbAccM : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiAccT2accM { get; set; }
        public int SiAccT { get; set; }
        public int SiAccM { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
        public virtual CtbAccT SiAccTNavigation { get; set; }
    }
}
