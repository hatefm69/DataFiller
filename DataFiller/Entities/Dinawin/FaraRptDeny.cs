using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraRptDeny : DinawinBaseEntity, IMyEntityDinawin
    {
        public short SysusersUid { get; set; }
        public int FaraRptListSi { get; set; }
    }
}
