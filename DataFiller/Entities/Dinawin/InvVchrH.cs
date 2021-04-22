using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvVchrH()
        {
            InvVchrD = new HashSet<InvVchrD>();
        }

        public int InvVchrHId { get; set; }
        public DateTime? InvVchrHDate { get; set; }
        public DateTime? InvVchrHDateFrom { get; set; }
        public DateTime? InvVchrHDateUntil { get; set; }
        public string InvVchrHTx { get; set; }
        public bool InvVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InvDocTypSi { get; set; }

        public virtual AccHdoc AccDocHSiNavigation { get; set; }
        public virtual InvDocTyp InvDocTypSiNavigation { get; set; }
        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual ICollection<InvVchrD> InvVchrD { get; set; }
    }
}
