using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocSms : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocSmsSi { get; set; }
        public string InvDocSmsTp { get; set; }
    }
}
