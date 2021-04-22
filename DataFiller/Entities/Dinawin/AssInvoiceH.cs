using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssInvoiceH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssInvoiceHSi { get; set; }
        public string AssInvoiceHCu { get; set; }
        public DateTime? AssInvoiceHDate { get; set; }
        public int? AssCustSi { get; set; }
        public int? AssReceptionSi { get; set; }
        public bool? AssInvoiceHCashflag { get; set; }
        public bool? AssInvoiceHNotcashflag { get; set; }
        public string AssInvoiceHNote { get; set; }
        public bool? AssInvoiceHLock { get; set; }
        public bool? AssInvoiceHAccDoc { get; set; }
        public bool? AssInvoiceHCancled { get; set; }
    }
}
