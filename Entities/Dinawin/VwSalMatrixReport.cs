using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalMatrixReport : DinawinBaseEntity, IMyEntityDinawin
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
        public decimal? مقدار { get; set; }
        public decimal? بدهکار { get; set; }
        public string نوعارز { get; set; }
        public double? مبلغارز { get; set; }
        public double? مبلغنهاييارز { get; set; }
        public string شرحعاملرديفي1 { get; set; }
        public double? مبلغعاملرديفي1 { get; set; }
        public string شرحعاملرديفي2 { get; set; }
        public double? مبلغعاملرديفي2 { get; set; }
        public double? کسورات2 { get; set; }
        public double? اضافات2 { get; set; }
        public double? کسورات { get; set; }
        public double? اضافات { get; set; }
        public double? جمعکسورات { get; set; }
        public double? جمعاضافات { get; set; }
        public decimal جمعميلغفاکتور { get; set; }
        public decimal جمعکلفاکتور { get; set; }
        public decimal جمعاضافاتفاکتور { get; set; }
        public decimal فاکتورجمعکسورات { get; set; }
        public decimal? جمع { get; set; }
        public string ايجادکننده { get; set; }
        public string عاملرديفي3 { get; set; }
        public double? مقدارعامل3 { get; set; }
        public double? كسورات3 { get; set; }
        public double? اضافات3 { get; set; }
        public string نامويزيتور { get; set; }
        public string نامشهر { get; set; }
        public DateTime? تاریخانقضایمیلادی { get; set; }
        public int? شمارهفرعی { get; set; }
        public bool ابطالی { get; set; }
        public int? ردیف { get; set; }
        public decimal? قیمتواحد { get; set; }
        public string توضیحات { get; set; }
        public string شمارهفنی { get; set; }
        public string کدواحد { get; set; }
        public string عنوانواحدسنجش { get; set; }
        public string کدمرکز { get; set; }
        public string ناممرکزفروش { get; set; }
        public string کدانبار { get; set; }
        public string نامانبار { get; set; }
        public string تلفن { get; set; }
        public string آدرس { get; set; }
        public string کدگروهمشتری { get; set; }
        public string گروهمشتری { get; set; }
        public decimal? جمعکلردیف { get; set; }
        public string کدپستی { get; set; }
        public string کداقتصادی { get; set; }
        public string کدرهگیریردیف { get; set; }
        public string کدرهگیریسند { get; set; }
        public int? شمارهپیشفاکتور { get; set; }
        public string استان { get; set; }
        public string شهرستان { get; set; }
        public string کدملی { get; set; }
        public string شرحلاتینکالا { get; set; }
    }
}
