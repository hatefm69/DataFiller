using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccOrdrTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccOrdrTypSi { get; set; }
        public string AccOrdrTypTp { get; set; }
    }
}
