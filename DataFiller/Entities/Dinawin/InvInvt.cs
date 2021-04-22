using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Dinawin
{
    public partial class InvInvt : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvInvt()
        {
            InvBatchNumber = new HashSet<InvBatchNumber>();
            InvCntH = new HashSet<InvCntH>();
            InvDocAutoInvInvtSiDestNavigation = new HashSet<InvDocAuto>();
            InvDocAutoInvInvtSiSourceNavigation = new HashSet<InvDocAuto>();
            InvDocH = new HashSet<InvDocH>();
            InvGdsToGds = new HashSet<InvGdsToGds>();
            InvGdsToInv = new HashSet<InvGdsToInv>();
            InvVchrH = new HashSet<InvVchrH>();
            PrdcTraceH = new HashSet<PrdcTraceH>();
            PurRqstH = new HashSet<PurRqstH>();
            SalInvcH = new HashSet<SalInvcH>();
            SalRetInvcH = new HashSet<SalRetInvcH>();
        }
        public int InvInvtSi { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string InvInvtAddress { get; set; }
        public int InvInvtSiParent { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public short? InvInvtTypeSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public bool? InvInvtIsActive { get; set; }
        public bool? InvInvtIsActiveSale { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual ICollection<InvBatchNumber> InvBatchNumber { get; set; }
        public virtual ICollection<InvCntH> InvCntH { get; set; }
        public virtual ICollection<InvDocAuto> InvDocAutoInvInvtSiDestNavigation { get; set; }
        public virtual ICollection<InvDocAuto> InvDocAutoInvInvtSiSourceNavigation { get; set; }
        public virtual ICollection<InvDocH> InvDocH { get; set; }
        public virtual ICollection<InvGdsToGds> InvGdsToGds { get; set; }
        public virtual ICollection<InvGdsToInv> InvGdsToInv { get; set; }
        public virtual ICollection<InvVchrH> InvVchrH { get; set; }
        public virtual ICollection<PrdcTraceH> PrdcTraceH { get; set; }
        public virtual ICollection<PurRqstH> PurRqstH { get; set; }
        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalRetInvcH> SalRetInvcH { get; set; }
    }
}
