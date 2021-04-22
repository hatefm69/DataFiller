using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerMajor : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerMajorSi { get; set; }
        public string PerMajorCu { get; set; }
        public string PerMajorTp { get; set; }
    }
}
