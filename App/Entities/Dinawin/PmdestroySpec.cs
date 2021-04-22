using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmdestroySpec : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmDestroySpecId { get; set; }
        public int? PmDestroySpecCode { get; set; }
        public string PmDestroySpecDesc { get; set; }
    }
}
