using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRegionToSalResp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRegionToSalRespSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalRegionSi { get; set; }
        public DateTime? SalRegionToSalRespDs { get; set; }
        public bool? SalRegionToSalRespAct { get; set; }
    }
}
