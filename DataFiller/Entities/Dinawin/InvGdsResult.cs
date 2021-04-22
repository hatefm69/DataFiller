using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsResult : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsResultSi { get; set; }
        public string InvGdsResultTp { get; set; }
    }
}
