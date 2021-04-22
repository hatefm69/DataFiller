using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstAssetSummary : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public string AstAssetTx { get; set; }
        public DateTime? AstAssetDprcDate { get; set; }
        public DateTime? LastDepreciateDate { get; set; }
        public decimal? Adepreciate { get; set; }
        public decimal? BookValue { get; set; }
        public decimal? FinalCost { get; set; }
        public string Location { get; set; }
        public string AstGrupTx { get; set; }
        public string AstGrupId { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi1 { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public string Reference { get; set; }
        public bool? AstAssetAccDoc1 { get; set; }
        public bool? AstAssetAccDoc { get; set; }
        public decimal AstAssetFirstAdepreciate { get; set; }
        public decimal? AstAssetDprcPrice { get; set; }
        public int? AstGrupIdParent { get; set; }
        public int? SiCost { get; set; }
        public string TpCost { get; set; }
        public string AstLctnTx { get; set; }
        public int? SiProject { get; set; }
    }
}
