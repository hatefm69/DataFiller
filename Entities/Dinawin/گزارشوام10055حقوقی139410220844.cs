using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class گزارشوام10055حقوقی139410220844 : DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدپرسنل { get; set; }
        public string نامپرسنل { get; set; }
        public string تاریخ { get; set; }
        public decimal مبلغ { get; set; }
        public int? دوره { get; set; }
        public string نامماه { get; set; }
        public string شمارهحساب { get; set; }
        public string شعبه { get; set; }
        public string بهحروف { get; set; }
        public int PerprsnlSi { get; set; }
    }
}
