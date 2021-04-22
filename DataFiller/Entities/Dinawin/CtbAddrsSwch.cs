using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAddrsSwch : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CtbAddrsSwchSi { get; set; }
        public int CtbAddrsSi { get; set; }
        public string CtbAddrsSwchTbl { get; set; }
        public int CtbAddrsSwchTblSi { get; set; }
        public bool? CtbAddrsSwchActive { get; set; }

        public virtual CtbAddrs CtbAddrsSiNavigation { get; set; }
    }
}
