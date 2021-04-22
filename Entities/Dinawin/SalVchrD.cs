using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalVchrDId { get; set; }
        public int SalVchrHId { get; set; }
        public int SalVchrDType { get; set; }
        public int SalVchrDReferenceId { get; set; }
        public string SalVchrDTx { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public decimal SalVchrDDebit { get; set; }
        public decimal SalVchrDCredit { get; set; }
        public int? SalVchrHRow { get; set; }
        public decimal? SalVchrDDebitC { get; set; }
        public decimal? SalVchrDCreditC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual SalVchrH SalVchrH { get; set; }
    }
}
