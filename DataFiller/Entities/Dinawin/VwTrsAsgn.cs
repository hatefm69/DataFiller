using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAsgn : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsAsgnSi { get; set; }
        public string TrsAsgnTp { get; set; }
        public string TrsAsgnGrpSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public bool? TrsAsgnUp { get; set; }
        public bool? TrsAsgnUr { get; set; }
        public string TrsAsgnGrpTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public bool TrsAsgnAct { get; set; }
        public string AccLcTp2 { get; set; }
        public string AccLpcTp2 { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLtTp2 { get; set; }
    }
}
