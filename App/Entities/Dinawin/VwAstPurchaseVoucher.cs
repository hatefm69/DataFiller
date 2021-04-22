using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstPurchaseVoucher : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public string AstAssetTx { get; set; }
        public DateTime AstAssetPurchaseDate { get; set; }
        public decimal AstAssetPurchasePrice { get; set; }
        public int? AstAssetPurchaseVchrId { get; set; }
        public string AstGrupId { get; set; }
        public string AstGrupTx { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public int? SiCost { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? SiProject { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public int? PurvndrSi { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi1 { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
    }
}
