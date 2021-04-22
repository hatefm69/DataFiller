using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class گزارشخزانهداری1005اسنادباز139410220844 : DinawinBaseEntity, IMyEntityDinawin
    {
        public DateTime? تاریخ { get; set; }
        public decimal? بدهکار { get; set; }
        public decimal? بستانکار { get; set; }
        public double? شمارهچک { get; set; }
        public string بانک { get; set; }
        public string شعبه { get; set; }
        public string شمارهحساب { get; set; }
        public int? شمارهسند { get; set; }
        public DateTime تاریخسند { get; set; }
        public string _1 { get; set; }
        public string وضعیت { get; set; }
        public string نوعوجه { get; set; }
        public string منبع { get; set; }
        public string شرحمنبع { get; set; }
        public string عطف { get; set; }
    }
}
