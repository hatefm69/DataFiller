using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvUnt : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvUnt()
        {
            InvDocD = new HashSet<InvDocD>();
            InvGdsTyp = new HashSet<InvGdsTyp>();
            InvUntCnvrt = new HashSet<InvUntCnvrt>();
            InvUntRelated = new HashSet<InvUntRelated>();
            SalDclrPrcD = new HashSet<SalDclrPrcD>();
            SalInvcD = new HashSet<SalInvcD>();
            SalPreInvcD = new HashSet<SalPreInvcD>();
            SalPreInvcSrvD = new HashSet<SalPreInvcSrvD>();
            SalRequestD = new HashSet<SalRequestD>();
            SalRetInvcD = new HashSet<SalRetInvcD>();
            SalePreInvoiceDetail = new HashSet<SalePreInvoiceDetail>();
        }

        public int InvUntSi { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }

        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvGdsTyp> InvGdsTyp { get; set; }
        public virtual ICollection<InvUntCnvrt> InvUntCnvrt { get; set; }
        public virtual ICollection<InvUntRelated> InvUntRelated { get; set; }
        public virtual ICollection<SalDclrPrcD> SalDclrPrcD { get; set; }
        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
        public virtual ICollection<SalPreInvcD> SalPreInvcD { get; set; }
        public virtual ICollection<SalPreInvcSrvD> SalPreInvcSrvD { get; set; }
        public virtual ICollection<SalRequestD> SalRequestD { get; set; }
        public virtual ICollection<SalRetInvcD> SalRetInvcD { get; set; }
        public virtual ICollection<SalePreInvoiceDetail> SalePreInvoiceDetail { get; set; }
    }
}
