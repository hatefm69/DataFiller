using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccMuser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiAccMuser { get; set; }
        public int? SiAccM { get; set; }
        public string UserRec { get; set; }
    }
}
