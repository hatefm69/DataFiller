using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstAsset : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public string AstAssetTx { get; set; }
        public string AstGrupId { get; set; }
        public DateTime? AstAssetExploitationDate { get; set; }
        public DateTime AstAssetPurchaseDate { get; set; }
        public decimal AstAssetPurchasePrice { get; set; }
        public int? AstAssetPurchaseVchrId { get; set; }
        public DateTime? AstAssetSaleDate { get; set; }
        public decimal AstAssetSalePrice { get; set; }
        public int? AstAssetSaleVchrId { get; set; }
        public DateTime? AstAssetScrapDate { get; set; }
        public decimal AstAssetScrapPrice { get; set; }
        public int? AstAssetScrapVchrId { get; set; }
        public DateTime? AstAssetFirstDate { get; set; }
        public decimal AstAssetFirstAdepreciate { get; set; }
        public decimal AstAssetFirstBookValue { get; set; }
        public string AstGrupTx { get; set; }
        public byte? AstCnsMthdId { get; set; }
        public double? AstGrupDepreciateRate { get; set; }
        public string AstCnsMthdTx { get; set; }
        public string AstSumId { get; set; }
        public string AstSumTx { get; set; }
        public int? AstLctnId { get; set; }
        public string AstLctnTx { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? SiCost { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public int? PurvndrSi { get; set; }
        public int? AccTSi { get; set; }
        public int? AccMSi { get; set; }
        public int? Expr1 { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi1 { get; set; }
        public bool? AstAssetAccDoc { get; set; }
        public bool? AstAssetAccDoc1 { get; set; }
        public int? AccMgrpSi1 { get; set; }
        public int? AccTgrpSi1 { get; set; }
        public int? SiProject { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public decimal? AstAssetAjstPriceInc { get; set; }
        public decimal? AstAssetAjstPriceDec { get; set; }
        public int? PurVndrSi1 { get; set; }
        public string PurVndrCu1 { get; set; }
        public string PurVndrTp1 { get; set; }
        public int? AstInfo1Si { get; set; }
        public string AstInfo1Tx { get; set; }
        public string AstInfo2Tx { get; set; }
        public int? AstInfo2Si { get; set; }
        public int? AstInfo3Si { get; set; }
        public int? AstInfo4Si { get; set; }
        public string AstInfo3Tx { get; set; }
        public string AstInfo4Tx { get; set; }
        public double? AstAssetFirstPrc { get; set; }
        public double? AstAssetFirstEst { get; set; }
        public double? AstAssetFirstBookv { get; set; }
    }
}
