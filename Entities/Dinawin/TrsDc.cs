using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDc : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsDc()
        {
            TrsDcAttach = new HashSet<TrsDcAttach>();
            TrsDcC = new HashSet<TrsDcC>();
            TrsDocVchr = new HashSet<TrsDocVchr>();
            TrsDocVchrH = new HashSet<TrsDocVchrH>();
        }

        public int TrsDcSi { get; set; }
        public int? TrsDcCu { get; set; }
        public short TrsDcTypSi { get; set; }
        public DateTime TrsDcDt { get; set; }
        public int? TrsDcGrpSi { get; set; }
        public string TrsDcTp { get; set; }
        public bool TrsDcShare { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public byte? CtbMnthSi { get; set; }
        public int? TrsdcCu2 { get; set; }
        public DateTime? TrsDcStmpCdt { get; set; }
        public string TrsDcStmpTime { get; set; }
        public string TrsDcStmpTimeEdit { get; set; }
        public DateTime? TrsDcStmpMdt { get; set; }
        public string StmpMus { get; set; }

        public virtual CtbMnth CtbMnthSiNavigation { get; set; }
        public virtual TrsDcGrp TrsDcGrpSiNavigation { get; set; }
        public virtual TrsDcTyp TrsDcTypSiNavigation { get; set; }
        public virtual ICollection<TrsDcAttach> TrsDcAttach { get; set; }
        public virtual ICollection<TrsDcC> TrsDcC { get; set; }
        public virtual ICollection<TrsDocVchr> TrsDocVchr { get; set; }
        public virtual ICollection<TrsDocVchrH> TrsDocVchrH { get; set; }
    }
}
