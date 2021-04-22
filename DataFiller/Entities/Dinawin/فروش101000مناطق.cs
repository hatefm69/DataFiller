using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class فروش101000مناطق : DinawinBaseEntity, IMyEntityDinawin
    {
        public string مناطق { get; set; }
        public string نامواسط { get; set; }
        public string کدگروه { get; set; }
        public string نامگروه { get; set; }
        public string نامانبار { get; set; }
        public string کدمرکز { get; set; }
        public string ناممرکز { get; set; }
        public string کدمشتری { get; set; }
        public string ناممشتری { get; set; }
        public string تاریخ { get; set; }
        public decimal? مبلغ { get; set; }
        public decimal? اضافات { get; set; }
        public decimal? کسورات { get; set; }
        public int? SalregionSi { get; set; }
        public int? InvinVtSi { get; set; }
        public int SalCustSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public decimal? مبلغکل { get; set; }
        public decimal? مبلغبرگشتی { get; set; }
    }
}
