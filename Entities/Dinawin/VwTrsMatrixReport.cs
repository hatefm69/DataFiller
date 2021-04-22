using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsMatrixReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public string تاريخعمليات { get; set; }
        public string بابت { get; set; }
        public decimal بدهكار { get; set; }
        public decimal? بستانكار { get; set; }
        public double بدهكارارزی { get; set; }
        public double بستانكارارزی { get; set; }
        public double? Ex { get; set; }
        public int? CtbCurncySi { get; set; }
        public decimal? بدهكارمانده { get; set; }
        public decimal? بستانكارمانده { get; set; }
        public double ماندهبدهکارارزی { get; set; }
        public double بستانكارارزیمانده { get; set; }
        public decimal? مانده { get; set; }
        public double? ماندهارزی { get; set; }
        public string كدمعين { get; set; }
        public string معين { get; set; }
        public string كدتفصيلي { get; set; }
        public string تفصيلي { get; set; }
        public string كدمركز { get; set; }
        public string مركز { get; set; }
        public string كدپروژه { get; set; }
        public string پروژه { get; set; }
        public string منبع { get; set; }
        public double? شمارهچك { get; set; }
        public string بانك { get; set; }
        public string شعبه { get; set; }
        public string شمارهحساب { get; set; }
        public string وضعيت { get; set; }
        public int? شمارهسند { get; set; }
        public string نوع { get; set; }
        public int? شمارهSiسندحسابداري { get; set; }
        public string توضيحات { get; set; }
        public string نامارز { get; set; }
        public double? نرخارز { get; set; }
        public string نامكاربرثبتكننده { get; set; }
    }
}
