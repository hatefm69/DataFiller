using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvTypSi { get; set; }
        public string InvTypCu { get; set; }
        public string InvTypTp { get; set; }
    }
}
