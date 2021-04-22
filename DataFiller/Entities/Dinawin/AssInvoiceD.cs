using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssInvoiceD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssInvoiceDSi { get; set; }
        public int? AssSrvDSi { get; set; }
        public int AssInvoiceHSi { get; set; }
        public int? AssInvGdsSi { get; set; }
        public int? AssInvGdsQty { get; set; }
        public decimal? AssInvoiceDFee { get; set; }
        public decimal? AssInvoiceDAmntQty { get; set; }
        public decimal? AssInvoiceDDisCount { get; set; }
        public decimal? AssInvoiceDTotalDisCount { get; set; }
        public double? AssInvoiceDToll { get; set; }
        public decimal? AssInvoiceDAmntToll { get; set; }
        public decimal? AssInvoiceDTotal { get; set; }
        public string AssInvGdsCu { get; set; }
        public string AssInvGdsTx { get; set; }
    }
}
