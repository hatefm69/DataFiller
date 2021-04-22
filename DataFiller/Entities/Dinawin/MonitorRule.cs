using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class MonitorRule : DinawinBaseEntity, IMyEntityDinawin
    {
        public int Code { get; set; }
        public string RuleExpr { get; set; }
    }
}
