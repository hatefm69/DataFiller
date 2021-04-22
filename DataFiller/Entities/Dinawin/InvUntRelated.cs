using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvUntRelated : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvUntSi { get; set; }
        public int InvUntSiParent { get; set; }

        public virtual InvUnt InvUntSiParentNavigation { get; set; }
    }
}
