using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCntCustomer : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntCustomerSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public int? CtbCustVndrTypSi { get; set; }
        public string CtbCustVndrTypTp { get; set; }
        public short? SalCustCorporateTyp { get; set; }
    }
}
