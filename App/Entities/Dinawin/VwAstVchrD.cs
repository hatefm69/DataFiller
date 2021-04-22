using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AstVchrDId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public decimal? AstVchrHDebit { get; set; }
        public decimal? AstVchrHCredit { get; set; }
        public string AstVchrDTx { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public DateTime? AstVchrHDate { get; set; }
        public int? AccDocHSi { get; set; }
        public int? SiHdoc { get; set; }
        public int? CuDoc { get; set; }
        public string TpHdoc { get; set; }
        public int AstVchrHId { get; set; }
        public string Reference { get; set; }
        public string Reference1 { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
    }
}
