using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntCustomer : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntCustomerSi { get; set; }
        public int? SalCustSi { get; set; }
    }
}
