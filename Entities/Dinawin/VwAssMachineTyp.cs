using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAssMachineTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssMachineTypSi { get; set; }
        public int? AssMachineTypCu { get; set; }
        public string AssMachineTypTp { get; set; }
        public int? AssMachineTypKm { get; set; }
        public int? AssMachineTypGuranteDur { get; set; }
        public int? AssMachineTypFirstGuranteDur { get; set; }
    }
}
