using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalShpInvoice : DinawinBaseEntity, IMyEntityDinawin
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
        public string ShpInvoiceDBarCode { get; set; }
        public int? InvGdsSi { get; set; }
        public decimal? ShpInvoiceDPrice { get; set; }
        public int? ShpInvoiceDSerial { get; set; }
        public int? ShpInvoiceDQty { get; set; }
        public int? ShpInvoiceDUnitPrice { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCu { get; set; }
        public string ShpCashierPassword { get; set; }
        public int InvGdsGrpSi { get; set; }
    }
}
