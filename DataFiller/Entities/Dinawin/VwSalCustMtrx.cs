using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalCustMtrx: DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدمشتری { get; set; }
        public string ناممشتری { get; set; }
        public string کدگروهمشتری { get; set; }
        public string نامگروهمشتری { get; set; }
        public string کدواسطفروش { get; set; }
        public string نامواسطفروش { get; set; }
        public string کدشعبه { get; set; }
        public string نامشعبه { get; set; }
        public bool? فعال { get; set; }
        public string نامرابط2 { get; set; }
        public string نامکمکی1 { get; set; }
        public string نحوهآشنایی { get; set; }
        public string اشخاصمعروف { get; set; }
        public string تاريخاولينتماس { get; set; }
        public double? متراژفروشگاهی { get; set; }
        public string مالک { get; set; }
        public string نوعفعاليت { get; set; }
        public bool? تابلویتبليغاتی { get; set; }
        public string شمارهپروانهکسب { get; set; }
        public int? ابعادفروشگاه { get; set; }
        public string مشخصاتتابلو { get; set; }
        public string SalCustPursuitTp { get; set; }
        public string محصولکنونی { get; set; }
        public string توضيحات { get; set; }
        public string تاریختولدرابط { get; set; }
        public string تاریخمناسبتخاصرابط { get; set; }
        public string نامرابط { get; set; }
    }
}
