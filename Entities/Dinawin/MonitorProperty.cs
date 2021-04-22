using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class MonitorProperty : DinawinBaseEntity, IMyEntityDinawin
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Hotkey { get; set; }
    }
}
