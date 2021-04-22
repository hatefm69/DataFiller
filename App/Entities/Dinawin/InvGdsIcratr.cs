using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsIcratr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsIcratrSi { get; set; }
        public string InvGdsIcratrTp { get; set; }
        public string InvGdsIcratrCu { get; set; }
    }
}
