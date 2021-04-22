using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDelivery : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvdeliverySi { get; set; }
        public string InvdeliveryCu { get; set; }
        public string InvdeliveryTp { get; set; }
    }
}
