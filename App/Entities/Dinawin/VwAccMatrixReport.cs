using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccMatrixReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? شمارهسند { get; set; }
        public int? شمارهفرعیسند { get; set; }
        public string تاریخسند { get; set; }
        public string شرح { get; set; }
        public decimal بدهکار { get; set; }
        public decimal بستانکار { get; set; }
        public decimal? مانده { get; set; }
        public string کدکل { get; set; }
        public string کدمعین { get; set; }
        public string کدتفصیل { get; set; }
        public string کدمرکز { get; set; }
        public string کدپروژه { get; set; }
        public string کدنوعسند { get; set; }
        public int? سال { get; set; }
        public int? ماه { get; set; }
        public int? روز { get; set; }
        public string عنوانماه { get; set; }
        public string فصل { get; set; }
        public string شرحکلیسند { get; set; }
        public string کل { get; set; }
        public string عنوانکل { get; set; }
        public string معین { get; set; }
        public string عنوانمعین { get; set; }
        public string تفصیل { get; set; }
        public string عنوانتفصیل { get; set; }
        public string مرکز { get; set; }
        public string عنوانمرکز { get; set; }
        public string پروژه { get; set; }
        public string عنوانپروژه { get; set; }
        public string نوعسند { get; set; }
        public string مرحلهقطعی { get; set; }
        public bool? پیشنویس { get; set; }
        public double? ردیف { get; set; }
        public int شناسه { get; set; }
        public string عطف { get; set; }
        public int? اطلاعاتشماره { get; set; }
        public DateTime? اطلاعاتتاريخ { get; set; }
        public double? اطلاعاتمقدار { get; set; }
        public string ايجادكنندهسند { get; set; }
        public string نامماه { get; set; }
        public string نامسيستم { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public int? SiAccM { get; set; }
        public int? SiAccT { get; set; }
        public double DebitC { get; set; }
        public double CreditC { get; set; }
        public double? ExchangeRate { get; set; }
        public string CtbCurncyTp { get; set; }
    }
}
