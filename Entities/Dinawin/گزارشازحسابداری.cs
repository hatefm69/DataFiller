using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class گزارشازحسابداری : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CuDocType { get; set; }
        public int? شمارهسند { get; set; }
        public string تاریخسند { get; set; }
        public string سال { get; set; }
        public string ماه { get; set; }
        public string روز { get; set; }
        public string عنوانماه { get; set; }
        public string فصل { get; set; }
        public string شرحکلیسند { get; set; }
        public string کل { get; set; }
        public string کدکل { get; set; }
        public string عنوانکل { get; set; }
        public string معین { get; set; }
        public string کدمعین { get; set; }
        public string عنوانمعین { get; set; }
        public string تفصیل { get; set; }
        public string کدتفصیل { get; set; }
        public string عنوانتفصیل { get; set; }
        public string مرکز { get; set; }
        public string کدمرکز { get; set; }
        public string عنوانمرکز { get; set; }
        public string پروژه { get; set; }
        public string کدپروژه { get; set; }
        public string عنوانپروژه { get; set; }
        public string نوعسند { get; set; }
        public string مرحلهقطعی { get; set; }
        public bool? پیشنویس { get; set; }
        public double? ردیف { get; set; }
        public int? شمارهفرعیسند { get; set; }
        public int شناسه { get; set; }
        public string شرح { get; set; }
        public decimal بدهکار { get; set; }
        public decimal بستانکار { get; set; }
        public string عطف { get; set; }
        public int? اطلاعاتشماره { get; set; }
        public DateTime? اطلاعاتتاریخ { get; set; }
        public double? اطلاعاتمقدار { get; set; }
    }
}
