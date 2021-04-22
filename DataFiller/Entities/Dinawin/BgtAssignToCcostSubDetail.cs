using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAssignToCcostSubDetail : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtAssignToCcostSubDetailSi { get; set; }
        public int? BgtAssignToCcostDetailSi { get; set; }
        public decimal? BgtAssignToCcostSubDetailAmnt { get; set; }
        public DateTime? BgtAssignToCcostSubDetailDate { get; set; }
        public string BgtAssignToCcostSubDetailDesc { get; set; }
        public int? RequestId { get; set; }
    }
}
