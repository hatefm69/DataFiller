using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAsset : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstAsset()
        {
            AstAssetData = new HashSet<AstAssetData>();
            AstAssetDprc = new HashSet<AstAssetDprc>();
            AstAssetLctn = new HashSet<AstAssetLctn>();
            AstAssign = new HashSet<AstAssign>();
        }

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
        public string AstsumId { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? SiCost { get; set; }
        public int? AstLctnId { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public int? PurvndrSi { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi1 { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public bool? AstAssetAccDoc { get; set; }
        public bool? AstAssetAccDoc1 { get; set; }
        public string Reference { get; set; }
        public string AstAssetPelak { get; set; }
        public int? AstAssetDepreciateRate { get; set; }
        public DateTime? AstAssetDprcDate { get; set; }
        public byte? AssetAssignStatus { get; set; }
        public DateTime? AssetAssignedDate { get; set; }
        public int? SiProject { get; set; }
        public bool? AstAssetAccDoc2 { get; set; }
        public byte? AstAssetDisableCalc { get; set; }
        public int? PurVndrSi1 { get; set; }
        public bool? AstAssetLock { get; set; }
        public bool? AstAssetIsGift { get; set; }
        public bool? AstAssetActive { get; set; }
        public bool? AstAssetLockpart { get; set; }
        public string InvGdsCu { get; set; }
        public int? InvDocDSi { get; set; }
        public int? AstInfo1Si { get; set; }
        public int? AstInfo2Si { get; set; }
        public int? AstInfo3Si { get; set; }
        public int? AstInfo4Si { get; set; }
        public string AstAssetTxInfo { get; set; }
        public int? AstInfo1 { get; set; }
        public int? AstInfo2 { get; set; }
        public int? AstInfo3 { get; set; }
        public int? AstInfo4 { get; set; }
        public double? AstAssetFirstPrc { get; set; }
        public double? AstAssetFirstEst { get; set; }
        public double? AstAssetFirstBookv { get; set; }

        public virtual AstGrup AstGrup { get; set; }
        public virtual AstLctn AstLctn { get; set; }
        public virtual AstSum Astsum { get; set; }
        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
        public virtual PurVndr PurVndrSi1Navigation { get; set; }
        public virtual AstAssetSelling AstAssetSelling { get; set; }
        public virtual ICollection<AstAssetData> AstAssetData { get; set; }
        public virtual ICollection<AstAssetDprc> AstAssetDprc { get; set; }
        public virtual ICollection<AstAssetLctn> AstAssetLctn { get; set; }
        public virtual ICollection<AstAssign> AstAssign { get; set; }
    }
}
