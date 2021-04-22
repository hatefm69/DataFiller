using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalSaleSeason : DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدخریدار { get; set; }
        public string نامکالا { get; set; }
        public string کدکالا { get; set; }
        public string شرکتخریدار { get; set; }
        public int? کدنوعشخص { get; set; }
        public string عنواننوعشخص { get; set; }
        public int نوعخریدار { get; set; }
        public string نامخریدار { get; set; }
        public string شمارهاقتصادیخریدار { get; set; }
        public string کدملیخریدار { get; set; }
        public string تلفن { get; set; }
        public string کدپستی { get; set; }
        public string آدرس { get; set; }
        public int استان { get; set; }
        public int شهرستان { get; set; }
        public decimal? جمعناخالص { get; set; }
        public double? مالیاتبرارزشافزوده { get; set; }
        public double? عوارض { get; set; }
        public decimal? جمعخالص { get; set; }
        public decimal? Fasle1 { get; set; }
        public decimal? Fasle2 { get; set; }
        public decimal? Fasle3 { get; set; }
        public decimal? Fasle4 { get; set; }
    }
}
