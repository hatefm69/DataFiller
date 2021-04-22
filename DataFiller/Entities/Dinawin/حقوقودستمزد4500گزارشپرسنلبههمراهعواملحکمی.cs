using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class حقوقودستمزد4500گزارشپرسنلبههمراهعواملحکمی : DinawinBaseEntity, IMyEntityDinawin
    {
        public string تاریخشروعحکم { get; set; }
        public string تاریخاتمامحکم { get; set; }
        public string شمارهحکم { get; set; }
        public bool? حکمفعال { get; set; }
        public string کدپرسنلی { get; set; }
        public string نامپرسنل { get; set; }
        public decimal? کمکهزينهاولادطبقحکم { get; set; }
        public decimal? فوقالعادهکاربااشعه { get; set; }
        public decimal? افزايشقانونکار { get; set; }
        public decimal? سايرمزايا { get; set; }
        public decimal? کمکهزينهمسكنطبقحكم { get; set; }
        public decimal? بديآبوهوا { get; set; }
        public decimal? مزايايشغل { get; set; }
        public decimal? فوقالعادهکاربااشعهطبقحکم { get; set; }
        public decimal? حقجذبطبقحکم { get; set; }
        public decimal? مبلغنوبتكاري { get; set; }
        public decimal? سايرمزاياطبقحکم { get; set; }
        public decimal? حقلباسطبقحکم { get; set; }
        public decimal? كمكهزينهبنطبقحكم { get; set; }
        public decimal? بهرهوريطبقحکم { get; set; }
        public decimal? فوقالعادهسختيكارطبقحكم { get; set; }
        public decimal? ايابوذهابطبقحكم { get; set; }
        public decimal? حقمسئوليتوسرپرستيطبقحکم { get; set; }
        public decimal? حقمديريت { get; set; }
        public decimal? تفاوتتطبيقطبقحکم { get; set; }
        public decimal? حقوقثابتشاغل { get; set; }
        public decimal? کمکهزينهعائلهمنديطبقحکم { get; set; }
        public decimal? فوقالعادهخاصطبقحکم { get; set; }
        public decimal? رقمحقوقيمبناياضافهکار { get; set; }
    }
}
