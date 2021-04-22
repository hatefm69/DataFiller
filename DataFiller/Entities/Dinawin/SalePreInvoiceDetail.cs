using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalePreInvoiceDetail : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalePreInvoiceDetailId { get; set; }
        public int SalePreInvoiceId { get; set; }
        public int InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalePreInvoice SalePreInvoice { get; set; }
    }
}
