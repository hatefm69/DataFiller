using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerAirLine : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerAirLineSi { get; set; }
        public string PerAirLineTp { get; set; }
    }
}
