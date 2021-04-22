using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class ShpInvoiceH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int ShpInvoiceHId { get; set; }
        public DateTime? ShpInvoiceHDt { get; set; }
        public string ShpCashierId { get; set; }
        public DateTime? ShpInvoiceHCreateDt { get; set; }
        public DateTime? ShpInvoiceHLastModifiedDt { get; set; }
        public int? ShpInvoiceHPrintCounter { get; set; }
        public int? ShpInvoiceHEditCounter { get; set; }
        public bool? ShpInvoiceHCancelled { get; set; }
        public DateTime? ShpInvoiceHCancelledDt { get; set; }
        public decimal ShpInvoiceHTotal { get; set; }
        public decimal ShpInvoiceHDiscount { get; set; }
        public decimal ShpInvoiceHPayment { get; set; }
        public bool ShpInvoiceHReturn { get; set; }
    }
}
