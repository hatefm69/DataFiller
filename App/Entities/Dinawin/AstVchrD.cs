using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AstVchrDId { get; set; }
        public int AstVchrHId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public decimal? AstVchrHDebit { get; set; }
        public decimal? AstVchrHCredit { get; set; }
        public string AstVchrDTx { get; set; }
        public string Reference { get; set; }
        public string Reference1 { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }

        public virtual AstVchrH AstVchrH { get; set; }
    }
}
