using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmscArcAtegory : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmCarCategoryId { get; set; }
        public string PmCarCategoryCode { get; set; }
        public string PmCarCategoryDesc { get; set; }
        public int? PmCarCategoryUnitRefId { get; set; }
        public int? PmCarCategoryDayWork { get; set; }
        public double? PmCarCategoryCostStop { get; set; }
    }
}
