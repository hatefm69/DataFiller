using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerVchrDId { get; set; }
        public int PerVchrHId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string PerVchrDTx { get; set; }
        public decimal PerVchrDDebit { get; set; }
        public decimal PerVchrDCredit { get; set; }
        public string PerVchrDDate { get; set; }
        public int? PerVchrHRow { get; set; }
        public decimal? PerVchrDDebitC { get; set; }
        public decimal? PerVchrDCreditC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual PerVchrH PerVchrH { get; set; }
    }
}
