using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvBatchNumber : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvBatchNumberSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InvDocTypSi { get; set; }
        public string InvBatchNumberCode { get; set; }
        public int? InvDocDSi { get; set; }
        public int? InvDocHSi { get; set; }

        public virtual InvDocD InvDocDSiNavigation { get; set; }
        public virtual InvDocTyp InvDocTypSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvInvt InvInvtSiNavigation { get; set; }
    }
}
