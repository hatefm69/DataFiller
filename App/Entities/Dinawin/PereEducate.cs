using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PereEducate : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PereEducateSi { get; set; }
        public string PereEducateCu { get; set; }
        public string PereEducateTp { get; set; }
    }
}
