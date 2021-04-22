using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsChqP : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsChqPSi { get; set; }
        public int AccLtSi { get; set; }
        public int TrsChqPBgnNo { get; set; }
        public int TrsChqPEndNo { get; set; }
        public DateTime? TrsChqPDt { get; set; }
        public bool? EndCheck { get; set; }

        public virtual CtbAccT AccLtSiNavigation { get; set; }
    }
}
