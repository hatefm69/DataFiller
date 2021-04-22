using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerCmdprsnlCmdOprMtrx: DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدپرسنلی { get; set; }
        public string نامونامخانوادگی { get; set; }
        public string شمارهحکم { get; set; }
        public string شرححکم { get; set; }
        public string کدعامل { get; set; }
        public string شرحعامل { get; set; }
        public bool پرسنلفعال { get; set; }
        public string نامپدر { get; set; }
        public string شمارهشناسنامه { get; set; }
        public string محلصدور { get; set; }
        public string تاريختولد { get; set; }
        public bool? وضعيتتاهل { get; set; }
        public byte? تعدادفرزند { get; set; }
        public string سربازی { get; set; }
        public string تحصيلات { get; set; }
        public byte? جنسيت { get; set; }
        public string آدرس { get; set; }
        public string نامبانک { get; set; }
        public string شعبه { get; set; }
        public string شمارهحساب { get; set; }
        public string تاريخشروعحکم { get; set; }
        public string تاريخاتمامحکم { get; set; }
        public bool? حکمفعال { get; set; }
        public string تاريخحکم { get; set; }
        public string نوعحکم { get; set; }
        public int? توالیحکم { get; set; }
        public string مقدارمحاسبه { get; set; }
        public string نام { get; set; }
        public string نامخانوادگی { get; set; }
    }
}
