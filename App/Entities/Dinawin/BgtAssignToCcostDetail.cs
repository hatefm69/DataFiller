using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAssignToCcostDetail : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtAssignToCcostDetailSi { get; set; }
        public int? BgtAssignToCcostSi { get; set; }
        public decimal? BgtAssignToCcostDetailAmnt { get; set; }
        public DateTime? BgtAssignToCcostDetailDate { get; set; }
        public string BgtAssignToCcostDetailDesc { get; set; }
        public string BgtAssignToCcostDetailCu { get; set; }
        public int? SiAccM { get; set; }

        public virtual BgtAssignToCcost BgtAssignToCcostSiNavigation { get; set; }
    }
}
