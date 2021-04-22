using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerVehicleFlag : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerVehicleFlagSi { get; set; }
        public string PerVehicleFlagCu { get; set; }
        public string PerVehicleFlagTp { get; set; }
    }
}
