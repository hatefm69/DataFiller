using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerMamorPlace : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerMamorPlaceSi { get; set; }
        public string PerMamorPlaceCu { get; set; }
        public string PerMamorPlaceTp { get; set; }
    }
}
