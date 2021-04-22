using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmCauseDestroy : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmCauseDestroyId { get; set; }
        public int? PmCauseDestroyCode { get; set; }
        public string PmCauseDestroyDesc { get; set; }
        public string PmCauseDestroySolution { get; set; }
        public int? PmDestroySpecRefId { get; set; }
    }
}
