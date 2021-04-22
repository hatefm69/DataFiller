using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsRepGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsRepGdsSi { get; set; }
        public int? InvGdsMSi { get; set; }
        public int? InvGdsDSi { get; set; }

        public virtual InvGds InvGdsMSiNavigation { get; set; }
    }
}
