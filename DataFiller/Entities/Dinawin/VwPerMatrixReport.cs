using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerMatrixReport: DinawinBaseEntity, IMyEntityDinawin
    {
        public string کدپرسنل { get; set; }
        public string نامونامخانوادگی { get; set; }
        public bool فعال { get; set; }
        public string نامپدر { get; set; }
        public string شمارهشناسنامه { get; set; }
        public string محلصدور { get; set; }
        public string تاريختولد { get; set; }
        public bool? تاهل { get; set; }
        public byte? تعدادفرزند { get; set; }
        public string وضعيتسربازی { get; set; }
        public string تحصیلات { get; set; }
        public string تاريخاستخدام { get; set; }
        public string تاريخشروعبهکار { get; set; }
        public string تاريخترککار { get; set; }
        public byte? جنسيت { get; set; }
        public bool? ايرانی { get; set; }
        public string ايميل { get; set; }
        public string تلفن { get; set; }
        public string آدرس { get; set; }
        public string نامبانک { get; set; }
        public string نامشعبه { get; set; }
        public string شمارهحساب { get; set; }
        public string کدملی { get; set; }
        public string نامدانشگاه { get; set; }
        public string تاهل2 { get; set; }
        public string وضعيت { get; set; }
        public string ناحیه { get; set; }
    }
}
