using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAccIntro : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtAccIntroSi { get; set; }
        public int AccMSi { get; set; }
        public byte? BgtAccIntroNature { get; set; }
        public double? BgtAccIntroConst { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
    }
}
