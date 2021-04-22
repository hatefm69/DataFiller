using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalePreInvoice : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalePreInvoice()
        {
            SalePreInvoiceDetail = new HashSet<SalePreInvoiceDetail>();
            SalePreInvoiceOperation = new HashSet<SalePreInvoiceOperation>();
        }

        public int SalePreInvoiceId { get; set; }
        public int MemberShipId { get; set; }
        public int CustomerId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public double TotalPrice { get; set; }
        public double PureTotalPrice { get; set; }
        public double TotalPriceIncrease { get; set; }
        public double TotalPriceDecrease { get; set; }
        public byte[] SignImage { get; set; }
        public int? SaleTypeId { get; set; }

        public virtual SalCust Customer { get; set; }
        public virtual ICollection<SalePreInvoiceDetail> SalePreInvoiceDetail { get; set; }
        public virtual ICollection<SalePreInvoiceOperation> SalePreInvoiceOperation { get; set; }
    }
}
