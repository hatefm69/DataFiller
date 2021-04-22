using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCustBnk : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCustBnkSi { get; set; }
        public string SalCustBnkAccountNo { get; set; }
        public string SalCustBnkBranch { get; set; }
        public string SalCustBnkBankName { get; set; }
        public int? SalCustSi { get; set; }
    }
}
