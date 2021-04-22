using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerFn : DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerFnSi { get; set; }
        public string PerFnTp { get; set; }
    }
}
