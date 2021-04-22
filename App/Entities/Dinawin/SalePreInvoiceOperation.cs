using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalePreInvoiceOperation : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalePreInvoiceOperationId { get; set; }
        public int SalePreInvoiceId { get; set; }
        public int SalOprSi { get; set; }
        public double OperationTotalPrice { get; set; }

        public virtual SalePreInvoice SalePreInvoice { get; set; }
    }
}
