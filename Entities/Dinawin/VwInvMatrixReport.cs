using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvMatrixReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? شمارهسند { get; set; }
        public string تاريخسند { get; set; }
        public string نامانبار { get; set; }
        public string نوعسند { get; set; }
        public string شمارهعطف { get; set; }
        public string نامتامينکننده { get; set; }
        public string ناممشتری { get; set; }
        public string کدمشتری { get; set; }
        public string کدکالا { get; set; }
        public string نامکالا { get; set; }
        public double? تعداد { get; set; }
        public decimal قيمتواحد { get; set; }
        public decimal جمعکل { get; set; }
        public string پروژه { get; set; }
        public string مرکز { get; set; }
        public DateTime? تاريخميلادی { get; set; }
        public int? SiAccM { get; set; }
        public string نامتحویلدهنده { get; set; }
        public string کدتحویلدهنده { get; set; }
        public string نامتحویلگیرنده { get; set; }
        public string کدتحویلگیرنده { get; set; }
        public string سال { get; set; }
        public string ماه { get; set; }
        public string ناممعين { get; set; }
        public string نامتفضيلي { get; set; }
        public DateTime? تاریخانقضایمیلادی { get; set; }
    }
}
