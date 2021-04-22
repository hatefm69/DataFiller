using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalPurSeason : DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدفروشنده { get; set; }
        public string نامکالا { get; set; }
        public string کدکالا { get; set; }
        public string فروشندهشرکت { get; set; }
        public int? کدنوعشخص { get; set; }
        public string عنواننوعشخص { get; set; }
        public int نوعخریدار { get; set; }
        public string نامفروشنده { get; set; }
        public string شمارهاقتصادیفروشنده { get; set; }
        public string کدملیفروشنده { get; set; }
        public string تلفن { get; set; }
        public string کدپستی { get; set; }
        public string آدرس { get; set; }
        public int استان { get; set; }
        public int شهرستان { get; set; }
        public decimal جمعناخالص { get; set; }
    }
}
