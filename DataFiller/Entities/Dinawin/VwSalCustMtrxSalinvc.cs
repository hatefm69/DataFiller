using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalCustMtrxSalinvc: DinawinBaseEntity, IMyEntityDinawin
    {
        public string ناممشتري { get; set; }
        public string كدگروهمشتري { get; set; }
        public string نامگروهمشتري { get; set; }
        public string كدمشتري { get; set; }
        public string كدمعين { get; set; }
        public string ناممعين { get; set; }
        public string كدتفضيلي { get; set; }
        public string نامتفضيلي { get; set; }
        public string كدواسطفروش { get; set; }
        public string نامواسطفروش { get; set; }
        public string كدشعبه { get; set; }
        public string نامشعبه { get; set; }
        public string نامكاربرثبتكننده { get; set; }
        public string ناممنطقهفروش { get; set; }
        public string ناممسيرفروش { get; set; }
        public bool? فعال { get; set; }
        public string نامشهرستان { get; set; }
        public string ناماستان { get; set; }
        public string نامشهر { get; set; }
        public string كداقتصادي { get; set; }
        public string كدملي { get; set; }
        public string كدحساب { get; set; }
        public string شمارهحساب { get; set; }
        public string CtbAddrsBranch { get; set; }
        public string نامبانك { get; set; }
        public string ايميل { get; set; }
        public string آدرس { get; set; }
        public string مودم { get; set; }
        public string فكس { get; set; }
        public string تلفن { get; set; }
        public string موبايل { get; set; }
        public string كدپستي { get; set; }
        public string رابط { get; set; }
        public string اشخاصمعروف { get; set; }
        public string SalcustEnterduced { get; set; }
        public string تاريخورودپيگيري { get; set; }
        public string مالكيت { get; set; }
        public string نوعفعاليت { get; set; }
        public bool? تابلويتبليغاتي { get; set; }
        public string شمارهپروانهكسب { get; set; }
        public int? متراژ { get; set; }
        public string مشخصاتتابلو { get; set; }
        public string SalCustPursuitTp { get; set; }
        public bool? SalCustPursuit { get; set; }
        public int? دستهبندي { get; set; }
        public string محصولكنوني { get; set; }
        public string علتتغيير { get; set; }
        public string شرح { get; set; }
        public string تاريخآخرينپيگيري { get; set; }
        public string سمت { get; set; }
        public string نوعفروش { get; set; }
        public decimal? تعداددرفاكتور { get; set; }
        public decimal? قيمتواحددرفاكتور { get; set; }
        public decimal? جمعكلدرفاكتور { get; set; }
        public string كدكالا { get; set; }
        public string شرحكالا { get; set; }
        public string ماه { get; set; }
        public int? شمارهفرعی { get; set; }
        public bool ابطالی { get; set; }
        public int? شمارهاصلی { get; set; }
        public string کدگروهمشتری { get; set; }
        public string عنوانگروهمشتری { get; set; }
        public double? اضافات { get; set; }
        public double? کسورات { get; set; }
        public decimal? جمعکل { get; set; }
        public string کدپستی { get; set; }
        public string کداقتصادی { get; set; }
        public double? نرخارز { get; set; }
        public double? جمعاضافات { get; set; }
        public double? جمعکسورات { get; set; }
        public string کدملی { get; set; }
        public string کدرهگیریسند { get; set; }
        public string کدرهگیریردیف { get; set; }
        public string کدگروهکالا { get; set; }
        public string گروهکالا { get; set; }
    }
}
