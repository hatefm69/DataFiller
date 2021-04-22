using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerHaml : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerHamlSi { get; set; }
        public string PerHamlTp { get; set; }
    }
}
