using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmService : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmServiceId { get; set; }
        public int? PmServiceCode { get; set; }
        public string PmServiceDesc { get; set; }
        public int? PmPriorityRefId { get; set; }
        public int? PmAccessRefId { get; set; }
        public int? PmServiceType { get; set; }
        public int? PmCarCategoryRefId { get; set; }
        public int? PmServiceTime { get; set; }
    }
}
