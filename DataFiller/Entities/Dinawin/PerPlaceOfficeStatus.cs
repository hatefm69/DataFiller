using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPlaceOfficeStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPlaceOfficeStatusSi { get; set; }
        public string PerPlaceOfficeStatusCu { get; set; }
        public string PerPlaceOfficeStatusTp { get; set; }
    }
}
