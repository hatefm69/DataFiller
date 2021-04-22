using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class خزانه101گزارشفهرستاسنادسررسیدگذشته139302091520 : DinawinBaseEntity, IMyEntityDinawin
    {
        public string تاریخ { get; set; }
        public short نوعوجه { get; set; }
        public string منبع { get; set; }
        public decimal بدهکار { get; set; }
        public decimal بستانکار { get; set; }
        public double? شمارهچک { get; set; }
        public string بانک { get; set; }
        public string شمارهحساب { get; set; }
        public string شرحسند { get; set; }
        public string شرحوضعیت { get; set; }
        public string نوعسند { get; set; }
        public string شرحمعین { get; set; }
        public string شرحتفضیلی { get; set; }
        public string شرح { get; set; }
        public string شرحدستی { get; set; }
        public double بدهکارارزی { get; set; }
        public double بستانکارارزی { get; set; }
        public string عطف { get; set; }
        public double? نوعارز { get; set; }
        public string شرحپروژه { get; set; }
        public string شرحمرکز { get; set; }
        public string ارز { get; set; }
        public string شرحتفضیلیمنبع { get; set; }
        public string شمارهسند { get; set; }
        public string شرحپروژهمنبع { get; set; }
        public string شرحمرکزمنبع { get; set; }
        public int? کدبانک { get; set; }
    }
}
