using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstPrepareVchr : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetDprcDate { get; set; }
        public decimal AstAssetDprcPrice { get; set; }
        public string AstGrupId { get; set; }
        public string AstGrupTx { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi1 { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public decimal? BookValue { get; set; }
        public int? AccLcSi1 { get; set; }
        public int? AccLpSi1 { get; set; }
        public int? AccLcSi2 { get; set; }
        public int? AccLpSi2 { get; set; }
    }
}
