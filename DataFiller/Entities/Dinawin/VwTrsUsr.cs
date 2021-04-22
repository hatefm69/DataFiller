using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsUsrSi { get; set; }
        public string TrsUsrTp { get; set; }
        public string LoginName { get; set; }
    }
}
