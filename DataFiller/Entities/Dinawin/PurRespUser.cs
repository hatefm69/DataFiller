using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurRespUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRespUserSi { get; set; }
        public int? PurRespSi { get; set; }
        public string UserRec { get; set; }
    }
}
