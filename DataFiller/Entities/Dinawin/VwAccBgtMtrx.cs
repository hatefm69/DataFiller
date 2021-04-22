using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccBgtMtrx : DinawinBaseEntity, IMyEntityDinawin
    {
        public string ماه { get; set; }
        public string عنوانماه { get; set; }
        public bool? فعال { get; set; }
        public string کدردیفبودجه { get; set; }
        public string عنوانردیفبودجه { get; set; }
        public double? مبلغدورهتقسیم { get; set; }
        public double? مبلغبودجه { get; set; }
    }
}
