using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCustGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCustGrp()
        {
            SalCust = new HashSet<SalCust>();
            SalDclrPrcD = new HashSet<SalDclrPrcD>();
        }

        public int SalCustGrpSi { get; set; }
        public string SalCustGrpCu { get; set; }
        public string SalCustGrpTp { get; set; }
        public int SalCustGrpSiParent { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
        public virtual ICollection<SalDclrPrcD> SalDclrPrcD { get; set; }
    }
}
