using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurReqstH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurReqstH()
        {
            PurReqstD = new HashSet<PurReqstD>();
        }

        public int PurReqstHSi { get; set; }
        public int? PurReqstHCu { get; set; }
        public DateTime? PurReqstHDt { get; set; }
        public string PurReqstHTp { get; set; }
        public string PurReqstHDocno { get; set; }
        public int? PurRqstCuseSi { get; set; }
        public int? PurReqstHApplyer { get; set; }
        public int? PurReqstHDeliverst { get; set; }
        public int? PurBuyStSi { get; set; }
        public bool? PurReqstHOk { get; set; }
        public byte? PurReqstHSts { get; set; }
        public int? PurRespSi { get; set; }
        public int? PurReqstHBuyKind { get; set; }
        public int? PurReqstHProcess { get; set; }
        public int? PurReqstHKindOrd { get; set; }
        public int? PurchaseOrderId { get; set; }

        public virtual ICollection<PurReqstD> PurReqstD { get; set; }
    }
}
