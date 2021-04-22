using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAssignToCcost : DinawinBaseEntity, IMyEntityDinawin
    {
        public BgtAssignToCcost()
        {
            BgtAssignToCcostDetail = new HashSet<BgtAssignToCcostDetail>();
        }

        public int BgtAssignToCcostSi { get; set; }
        public int? BgtAssignAccMSi { get; set; }
        public decimal? BgtAssignToCcostAmnt { get; set; }
        public int? SiCost { get; set; }
        public DateTime? BgtAssignToCcostDate { get; set; }

        public virtual BgtAssignAccM BgtAssignAccMSiNavigation { get; set; }
        public virtual CtbCost SiCostNavigation { get; set; }
        public virtual ICollection<BgtAssignToCcostDetail> BgtAssignToCcostDetail { get; set; }
    }
}
