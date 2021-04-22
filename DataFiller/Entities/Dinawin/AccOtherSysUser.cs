using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccOtherSysUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccOtherSysUserSi { get; set; }
        public string UserRec { get; set; }
        public int SiSystem { get; set; }
    }
}
