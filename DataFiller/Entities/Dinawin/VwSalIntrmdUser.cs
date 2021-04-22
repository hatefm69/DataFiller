using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalIntrmdUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalIntrmdSi { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
    }
}
