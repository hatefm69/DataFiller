using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class گزارشمساعده1004555حقوقی : DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدپرسنل { get; set; }
        public string نامپرسنل { get; set; }
        public string تاریخ { get; set; }
        public decimal مبلغ { get; set; }
        public int? دوره { get; set; }
        public string شمارهحساب { get; set; }
        public int PerprsnlSi { get; set; }
        public string شعبه { get; set; }
        public string بهحروف { get; set; }
        public string نامماه { get; set; }
    }
}
