using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerCmdMatrixReport: DinawinBaseEntity, IMyEntityDinawin
    {
        public string شمارهحکم { get; set; }
        public string شرححکم { get; set; }
        public string فعال { get; set; }
        public string کدپرسنلی { get; set; }
        public string نامپرسنل { get; set; }
        public string نوعحکم { get; set; }
        public string تاريخشروع { get; set; }
        public string تاريخاتمام { get; set; }
        public string سمت { get; set; }
        public string مرکزهزينه { get; set; }
        public string نوعاستخدام { get; set; }
        public string کدپست { get; set; }
        public string سازمان { get; set; }
        public string تاريخحکم { get; set; }
        public bool? معوقه { get; set; }
        public string نحوهمحاسبهحقوق { get; set; }
        public string کدمرکز { get; set; }
        public int? تعدادنفراتدرمرکز { get; set; }
        public string ناحیه { get; set; }
    }
}
