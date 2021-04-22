using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurReqProc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurReqProcSi { get; set; }
        public string PurReqProcTp { get; set; }
    }
}
