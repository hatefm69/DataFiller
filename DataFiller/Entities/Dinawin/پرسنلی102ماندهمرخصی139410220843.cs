using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class پرسنلی102ماندهمرخصی139410220843 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int كدپرسنلي { get; set; }
        public string نامخانوادگي { get; set; }
        public string نام { get; set; }
        public string مركز { get; set; }
        public double? تعدادروزهايكاركرد { get; set; }
        public int? تايمكس { get; set; }
        public double? استحقاقي { get; set; }
        public double? بدونحقوق { get; set; }
        public double? ساعتي { get; set; }
        public double? استعلاجي { get; set; }
        public int? غيبت { get; set; }
    }
}
