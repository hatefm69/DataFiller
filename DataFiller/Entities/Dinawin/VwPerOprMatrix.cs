using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerOprMatrix: DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدعامل { get; set; }
        public string شرحعامل { get; set; }
        public decimal? جمعمبلغ { get; set; }
        public int ماه { get; set; }
        public string کدپرسنلی { get; set; }
        public string نامپرسنل { get; set; }
        public int توالي { get; set; }
        public string مرکز { get; set; }
        public string نامبانک { get; set; }
        public string نامشعبه { get; set; }
        public string شمارهحساب { get; set; }
        public string کدپست { get; set; }
        public string پست { get; set; }
        public string واحد { get; set; }
        public string کدواحد { get; set; }
        public string كدشغل { get; set; }
        public string نامشغل { get; set; }
        public string ناحیه { get; set; }
    }
}
