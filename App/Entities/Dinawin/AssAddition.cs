using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssAddition : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssAdditionSi { get; set; }
        public string AssAdditionTp { get; set; }
    }
}
