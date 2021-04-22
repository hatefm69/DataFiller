using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvVchrDId { get; set; }
        public int InvVchrHId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string InvVchrDTx { get; set; }
        public decimal InvVchrDDebit { get; set; }
        public decimal InvVchrDCredit { get; set; }
        public string InvVchrDDate { get; set; }
        public int? InvVchrHRow { get; set; }
        public decimal? InvVchrDDebitC { get; set; }
        public decimal? InvVchrDCreditC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual InvVchrH InvVchrH { get; set; }
    }
}
