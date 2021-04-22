using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccTuser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiAccTuser { get; set; }
        public int? SiAccT { get; set; }
        public string UserRec { get; set; }
    }
}
