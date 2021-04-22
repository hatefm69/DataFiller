using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcA : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcASi { get; set; }
        public int TrsDcCSi { get; set; }
        public int? TrsAsgnSi { get; set; }
        public int? TrsRsrcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsDcATp { get; set; }
        public decimal TrsDcADebit { get; set; }
        public decimal TrsDcACredit { get; set; }
        public short TrsStsSi { get; set; }
        public int? TrsDcSSi { get; set; }
        public string TrsDcAAccDesc { get; set; }
        public int? AccDocHSi { get; set; }
        public double TrsDcADebitC { get; set; }
        public double TrsDcACreditC { get; set; }
        public int? Id { get; set; }
        public string TrsDcARfrnc { get; set; }
        public string TrsDcACuDoc { get; set; }
        public string TrsDcAIntrmd { get; set; }
        public double? ExchangeRate { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public bool? TrsDcAFirstCu { get; set; }
        public int? SecCuDoc { get; set; }
        public double? DebitC { get; set; }
        public double? CreditC { get; set; }
        public int? SalRespSi { get; set; }
        public string SalRespTp { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual TrsAsgn TrsAsgnSiNavigation { get; set; }
        public virtual TrsDcS TrsDcSSiNavigation { get; set; }
        public virtual TrsRsrc TrsRsrcSiNavigation { get; set; }
    }
}
