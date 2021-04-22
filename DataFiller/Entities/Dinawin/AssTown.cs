using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssTown : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AssTownCu { get; set; }
        public string AssTownTp { get; set; }
    }
}
