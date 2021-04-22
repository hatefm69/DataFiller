using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDocTyp()
        {
            InvBatchNumber = new HashSet<InvBatchNumber>();
            InvDocAutoInvDocTypSiDestNavigation = new HashSet<InvDocAuto>();
            InvDocAutoInvDocTypSiSourceNavigation = new HashSet<InvDocAuto>();
            InvDocH = new HashSet<InvDocH>();
            InvVchrH = new HashSet<InvVchrH>();
        }

        public int InvDocTypSi { get; set; }
        public string InvDocTypTp { get; set; }
        public int? InvDocTypSqnc { get; set; }
        public string InvDocTypTp2 { get; set; }

        public virtual ICollection<InvBatchNumber> InvBatchNumber { get; set; }
        public virtual ICollection<InvDocAuto> InvDocAutoInvDocTypSiDestNavigation { get; set; }
        public virtual ICollection<InvDocAuto> InvDocAutoInvDocTypSiSourceNavigation { get; set; }
        public virtual ICollection<InvDocH> InvDocH { get; set; }
        public virtual ICollection<InvVchrH> InvVchrH { get; set; }
    }
}
