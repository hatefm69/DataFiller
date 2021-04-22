using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmSysTem : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmSysTemId { get; set; }
        public int? PmSysTemCode { get; set; }
        public string PmSysTemDesc { get; set; }
        public int? PmCarCategoryRefId { get; set; }
    }
}
