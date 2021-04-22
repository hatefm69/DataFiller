using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsStsNx : DinawinBaseEntity, IMyEntityDinawin
    {
        public short TrsDcTypSi { get; set; }
        public short TrsCtypSi { get; set; }
        public short TrsStsSi { get; set; }
        public short TrsStsSiNx { get; set; }

        public virtual TrsSts Trs { get; set; }
        public virtual TrsSts TrsNavigation { get; set; }
    }
}
