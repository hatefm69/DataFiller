using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class حسابداری4600لیستاسنادهمراهباجمع : DinawinBaseEntity, IMyEntityDinawin
    {
        public long? ردیف { get; set; }
        public int? شمارهسند { get; set; }
        public string تاریخ { get; set; }
        public string کدکل { get; set; }
        public string نامکل { get; set; }
        public decimal? بدهکار { get; set; }
        public decimal? بستانکار { get; set; }
        public string HiddenStyle { get; set; }
    }
}
