using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAssVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssVchrHId { get; set; }
        public int AssVchrDId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string AssVchrDTx { get; set; }
        public decimal AssVchrDDebit { get; set; }
        public decimal AssVchrDCredit { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public DateTime AssVchrHDate { get; set; }
        public DateTime AssVchrHDateFrom { get; set; }
        public DateTime AssVchrHDateUntil { get; set; }
        public string AssVchrHTx { get; set; }
        public bool? AssVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? AssVchrHRow { get; set; }
        public double? AssVchrDDebitC { get; set; }
        public double? AssVchrDCreditC { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? ExchangeRate { get; set; }
    }
}
