using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssVchrDId { get; set; }
        public int AssVchrHId { get; set; }
        public int? AssVchrDReferenceId { get; set; }
        public string AssVchrDTx { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public decimal AssVchrDDebit { get; set; }
        public decimal AssVchrDCredit { get; set; }
        public int? AssVchrHRow { get; set; }
        public double? AssVchrDDebitC { get; set; }
        public double? AssVchrDCreditC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }

        public virtual AssVchrH AssVchrH { get; set; }
    }
}
