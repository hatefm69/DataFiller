﻿using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class فروش107خالصفروش139410220843 : DinawinBaseEntity, IMyEntityDinawin
    {
        public string واسط { get; set; }
        public decimal? تعداد { get; set; }
        public decimal? مبلغ { get; set; }
        public double? تعدادبرگشتی { get; set; }
        public decimal? مبلغبرگشتی { get; set; }
        public double? ماندهتعدادی { get; set; }
        public decimal? مانده { get; set; }
    }
}
