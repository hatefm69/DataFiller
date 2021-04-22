using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalRetMatrixReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? شمارهفاکتور { get; set; }
        public string تاريخفاکتور { get; set; }
        public string سال { get; set; }
        public string ماه { get; set; }
        public string روز { get; set; }
        public string کدمشتري { get; set; }
        public string ناممشتري { get; set; }
        public string شرحفاکتور { get; set; }
        public string کدکالا { get; set; }
        public string شرحکالا { get; set; }
        public double مقدار { get; set; }
        public double بدهکار { get; set; }
        public string نوعارز { get; set; }
        public double? مبلغارز { get; set; }
        public decimal? مبلغنهاييارز { get; set; }
        public string شرحعاملرديفي1 { get; set; }
        public double? مبلغعاملرديفي1 { get; set; }
        public string شرحعاملرديفي2 { get; set; }
        public double? مبلغعاملرديفي2 { get; set; }
        public decimal? کسورات2 { get; set; }
        public decimal? اضافات2 { get; set; }
        public decimal? کسورات { get; set; }
        public decimal? اضافات { get; set; }
        public double? جمعکسورات { get; set; }
        public double? جمعاضافات { get; set; }
        public decimal? جمعميلغفاکتور { get; set; }
        public decimal? جمعکلفاکتور { get; set; }
        public decimal? جمعاضافاتفاکتور { get; set; }
        public decimal? فاکتورجمعکسورات { get; set; }
        public decimal جمع { get; set; }
        public string ايجادکننده { get; set; }
        public string عامل3 { get; set; }
        public double? مقدارعامل3 { get; set; }
        public decimal? كسورات3 { get; set; }
        public decimal? اضافات3 { get; set; }
        public string کدرهگیریردیف { get; set; }
        public DateTime? تاریخانقضایمیلادی { get; set; }
        public string کدگروهمشتری { get; set; }
        public string نامگروهمشتری { get; set; }
        public decimal قیمتواحد { get; set; }
        public int? ردیف { get; set; }
        public string کدویزیتور { get; set; }
        public string نامویزیتور { get; set; }
        public string کدمرکزفروش { get; set; }
        public string عنوانمرکزفروش { get; set; }
        public string کدانبار { get; set; }
        public string عنوانانبار { get; set; }
        public string توضیحات { get; set; }
        public string کدواحدسنجش { get; set; }
        public string عنوانواحدسنجش { get; set; }
        public string شمارهفنی { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public string شمارهاقتصادی { get; set; }
        public string کدپستی { get; set; }
        public string تلفن { get; set; }
        public string آدرس { get; set; }
        public string کدرهگیریسند { get; set; }
    }
}
