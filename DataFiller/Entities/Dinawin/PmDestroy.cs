using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmDestroy : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmDestroyId { get; set; }
        public int? PmDestroyCode { get; set; }
        public string PmDestroyDesc { get; set; }
    }
}
