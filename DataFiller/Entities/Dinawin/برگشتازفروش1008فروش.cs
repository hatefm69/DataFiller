using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class برگشتازفروش1008فروش : DinawinBaseEntity, IMyEntityDinawin
    {
        public string کد { get; set; }
        public string نام { get; set; }
        public string تاریخ { get; set; }
        public string مرکز { get; set; }
        public string واسط { get; set; }
        public string گروه { get; set; }
        public double? مقدار { get; set; }
        public decimal? قیمت { get; set; }
    }
}
