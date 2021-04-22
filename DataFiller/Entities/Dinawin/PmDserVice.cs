using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmDserVice : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmDserviceId { get; set; }
        public int? PmDserviceCode { get; set; }
        public string PmDserviceDesc { get; set; }
        public int? PmDpriorityRefId { get; set; }
        public int? PmDaccessRefId { get; set; }
        public int? PmDserviceType { get; set; }
        public int? PmDcarCategoryRefId { get; set; }
        public int? PmDserviceTime { get; set; }
    }
}
