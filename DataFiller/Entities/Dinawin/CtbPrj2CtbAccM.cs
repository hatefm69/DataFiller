using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbPrj2CtbAccM : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiPrj2AccM { get; set; }
        public int SiProject { get; set; }
        public int SiAccM { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
        public virtual CtbProject SiProjectNavigation { get; set; }
    }
}
