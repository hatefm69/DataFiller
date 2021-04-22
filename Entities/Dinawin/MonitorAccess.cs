using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class MonitorAccess : DinawinBaseEntity, IMyEntityDinawin
    {
        public int Code { get; set; }
        public string DefaultBehavior { get; set; }
        public string ExceptUserNames { get; set; }
    }
}
