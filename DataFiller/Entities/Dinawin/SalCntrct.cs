using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCntrct : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCntrct()
        {
            SalCntrctGds = new HashSet<SalCntrctGds>();
            SalInvcH = new HashSet<SalInvcH>();
        }

        public string SalCntrctSi { get; set; }
        public int SalCustSi { get; set; }
        public string SalCntrctGrpSi { get; set; }
        public string SalCntrctTp { get; set; }
        public DateTime? SalCntrctCdt { get; set; }
        public DateTime? SalCntrctSdt { get; set; }
        public DateTime? SalCntrctEdt { get; set; }
        public decimal? SalCntrctPrc { get; set; }
        public string SalCntrctFileName { get; set; }
        public string SalCntrctTechMan { get; set; }
        public byte? SalCntrctStsSi { get; set; }
        public decimal SalCntrctPreRec { get; set; }
        public decimal SalCntrctSatis { get; set; }
        public decimal SalCntrctAnnx { get; set; }

        public virtual SalCntrctGrp SalCntrctGrpSiNavigation { get; set; }
        public virtual SalCntrctSts SalCntrctStsSiNavigation { get; set; }
        public virtual ICollection<SalCntrctGds> SalCntrctGds { get; set; }
        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
    }
}
