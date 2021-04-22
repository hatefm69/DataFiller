using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssReceptionKind : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssReceptionKindSi { get; set; }
        public string AssReceptionKindTp { get; set; }
    }
}
