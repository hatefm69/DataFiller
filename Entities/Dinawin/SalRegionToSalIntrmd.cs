using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRegionToSalIntrmd : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRegionToSalIntrmdSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalRegionPathSi { get; set; }
        public int? SalRegionSi { get; set; }
        public DateTime? SalRegionToSalIntrmdFrmDs { get; set; }
        public DateTime? SalRegionToSalIntrmdToDs { get; set; }
        public bool? SalRegionToSalIntrmdAct { get; set; }
    }
}
