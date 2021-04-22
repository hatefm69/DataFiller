using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class حسابداری115گزارشدفترروزنامه139205231143 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? شماره { get; set; }
        public string تاریخ { get; set; }
        public string کدکل { get; set; }
        public string نامکل { get; set; }
        public decimal? بدهکار { get; set; }
        public decimal? بستانکار { get; set; }
    }
}
