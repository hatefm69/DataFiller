using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Pmpriority : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmpriorityId { get; set; }
        public string PmpriorityCode { get; set; }
        public string PmpriorityDesc { get; set; }
    }
}
