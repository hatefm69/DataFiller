using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtPrdcSchdlH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtPrdcSchdlHSi { get; set; }
        public string BgtPrdcSchdHYear { get; set; }
        public int? ProductId { get; set; }
        public int? BgtPrdcSchdlHTotalQty { get; set; }
    }
}
