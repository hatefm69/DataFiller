using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class حسابداری103گزارشخلاصهاسناد139302091520 : DinawinBaseEntity, IMyEntityDinawin
    {
        public long? ردیفدرصفحه { get; set; }
        public long? گروهصفحه { get; set; }
        public long? ردیف { get; set; }
        public string شمارهسند { get; set; }
        public string تاریخ { get; set; }
        public string کدکل { get; set; }
        public string نامکل { get; set; }
        public decimal? بدهکار { get; set; }
        public decimal? بستانکار { get; set; }
        public decimal? جمع { get; set; }
        public long? شمارهسند2 { get; set; }
    }
}
