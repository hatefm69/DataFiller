using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerInsrncGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerInsrncGrp()
        {
            PerPrsnlD = new HashSet<PerPrsnlD>();
        }

        public byte PerInsrncGrpSi { get; set; }
        public string PerInsrncGrpTp { get; set; }
        public string PerInsrncGrpNo { get; set; }
        public string PerInsrncGrpAdrs { get; set; }
        public string PerInsrncGrpBrnch { get; set; }
        public string InsrncBnkEmployer { get; set; }
        public string InsrncBnkName { get; set; }
        public string InsrncBnkId { get; set; }
        public string InsrncBnkAdrs { get; set; }
        public int? AccLtSi { get; set; }

        public virtual ICollection<PerPrsnlD> PerPrsnlD { get; set; }
    }
}
