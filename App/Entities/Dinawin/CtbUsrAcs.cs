using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbUsrAcs : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CtbUsrAcsSi { get; set; }
        public string LoginName { get; set; }
        public string CtbAcsCu { get; set; }
    }
}
