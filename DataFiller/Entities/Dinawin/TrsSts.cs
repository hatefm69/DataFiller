using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsSts : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsSts()
        {
            TrsStsNxTrs = new HashSet<TrsStsNx>();
            TrsStsNxTrsNavigation = new HashSet<TrsStsNx>();
        }

        public short TrsDcTypSi { get; set; }
        public short TrsCtypSi { get; set; }
        public short TrsStsSi { get; set; }
        public int TrsStsTypSi { get; set; }
        public string TrsStsTp { get; set; }
        public int? TrsStsClr { get; set; }
        public string TrsStsNsts { get; set; }
        public string TrsStsNstsTp { get; set; }
        public byte? TrsStsFnSiDebit { get; set; }
        public byte? TrsStsFnSiCredit { get; set; }
        public string TrsStsIrfrncFld { get; set; }
        public string TrsStsInoFld { get; set; }
        public string TrsStsIdtFld { get; set; }
        public string TrsStsIqtyFld { get; set; }
        public string TrsStsAccDocDesc1 { get; set; }
        public string TrsStsAccDocDesc2 { get; set; }
        public bool? TrsStsAccBalance { get; set; }
        public string TrsStsTp2 { get; set; }

        public virtual TrsCtyp TrsCtypSiNavigation { get; set; }
        public virtual TrsDcTyp TrsDcTypSiNavigation { get; set; }
        public virtual TrsStsFn TrsStsFnSiCreditNavigation { get; set; }
        public virtual TrsStsFn TrsStsFnSiDebitNavigation { get; set; }
        public virtual ICollection<TrsStsNx> TrsStsNxTrs { get; set; }
        public virtual ICollection<TrsStsNx> TrsStsNxTrsNavigation { get; set; }
    }
}
