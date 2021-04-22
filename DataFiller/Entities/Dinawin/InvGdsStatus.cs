using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsStatusSi { get; set; }
        public string InvGdsStatusTp { get; set; }
    }
}
