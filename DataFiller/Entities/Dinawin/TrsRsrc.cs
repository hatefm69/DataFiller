using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsRsrc : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsRsrc()
        {
            TrsBnkCnflt = new HashSet<TrsBnkCnflt>();
            TrsDcA = new HashSet<TrsDcA>();
            TrsDcC = new HashSet<TrsDcC>();
            TrsRsrcUsr = new HashSet<TrsRsrcUsr>();
        }

        public int TrsRsrcSi { get; set; }
        public string TrsRsrcTp { get; set; }
        public int TrsRsrcTypSi { get; set; }
        public bool? TrsRsrcAct { get; set; }
        public int? CtbCurncySi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public decimal TrsRsrcMin { get; set; }
        public decimal TrsRsrcMax { get; set; }
        public decimal TrsRsrcMaxPay { get; set; }
        public string TrsRsrcBbrnch { get; set; }
        public string TrsRsrcBaccNo { get; set; }
        public string TrsRsrcBowner { get; set; }
        public int? AccLmSi2 { get; set; }
        public decimal TrsRsrcDebit { get; set; }
        public decimal TrsRsrcCredit { get; set; }
        public decimal TrsRsrcPrc { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsRsrcAddres { get; set; }
        public string TrsRsrcIno { get; set; }
        public string TrsRsrcPerson { get; set; }
        public string TrsRsrcManger { get; set; }

        public virtual CtbAccM AccLmSi2Navigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual CtbCurncy CtbCurncySiNavigation { get; set; }
        public virtual TrsRsrcTyp TrsRsrcTypSiNavigation { get; set; }
        public virtual ICollection<TrsBnkCnflt> TrsBnkCnflt { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
        public virtual ICollection<TrsDcC> TrsDcC { get; set; }
        public virtual ICollection<TrsRsrcUsr> TrsRsrcUsr { get; set; }
    }
}
