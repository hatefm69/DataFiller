using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsIcntry : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsIcntrySi { get; set; }
        public string InvGdsIcntryTp { get; set; }
        public string InvGdsIcntryCu { get; set; }
    }
}
