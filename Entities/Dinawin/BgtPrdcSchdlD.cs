using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtPrdcSchdlD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtPrdcSchdlDSi { get; set; }
        public int? BgtPrdcSchdlHSi { get; set; }
        public int? BgtPrdcSchdlDQty { get; set; }
        public byte? BgtPrdcSchdlDMonthId { get; set; }
    }
}
