using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class حسابداری113گزارشدفترکل13920513848139410220844 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? شمارهسند { get; set; }
        public string تاریخ { get; set; }
        public string کدکل { get; set; }
        public string نامکل { get; set; }
        public decimal? بدهکار { get; set; }
        public decimal? بستانکار { get; set; }
    }
}
