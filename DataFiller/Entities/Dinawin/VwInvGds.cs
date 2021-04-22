using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCm { get; set; }
        public int InvUntSi { get; set; }
        public int InvGdsGrpSi { get; set; }
        public double InvGdsQtyReal { get; set; }
        public double InvGdsQtyVirtual { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public bool InvGdsPrdGds { get; set; }
        public double InvGdsQtyMin { get; set; }
        public double InvGdsQtyMax { get; set; }
        public double InvGdsQtySafe { get; set; }
        public string InvGdsTechNo { get; set; }
        public int? InvGdsStatusSi { get; set; }
        public string InvGdsStatusTp { get; set; }
        public int? InvUntCount { get; set; }
        public int? PurGdsGrpSi { get; set; }
        public DateTime? InvGdsDateBirth { get; set; }
        public bool? InvGdsActive { get; set; }
        public double? InvGdsQtySale { get; set; }
        public bool? InvGdsActiveSale { get; set; }
        public bool? InvGdsActiveSerial { get; set; }
        public string InvGdsIcntryCu { get; set; }
        public string InvGdsIcntryTp { get; set; }
        public string InvGdsLname { get; set; }
        public decimal? InvGdsSalePrc { get; set; }
        public decimal? InvGdsStdPrc { get; set; }
        public decimal? InvGdsPurchasePrc { get; set; }
        public int? SiAccT { get; set; }
        public int? InvGdsIcratrSi { get; set; }
        public string InvGdsIcratrTp { get; set; }
        public string InvGdsIcratrCu { get; set; }
        public int? InvUntSiSale { get; set; }
        public string InvUntCuSale { get; set; }
        public string InvUntTpSale { get; set; }
        public decimal? InvGdsPurchasePrcC { get; set; }
        public int? Siaccm { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CtbCurncyTp { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? SalGdsAccAccMSi { get; set; }
        public int? SalGdsAccAccTSi { get; set; }
        public string SalGdsAccAccMTp { get; set; }
        public string SalGdsAccAccTTp { get; set; }
        public double? InvGdsQtyMinOrd { get; set; }
        public double? InvGdsQtyBestInWay { get; set; }
        public int? InvGdsCountdayInWay { get; set; }
        public bool? ShowInWeb { get; set; }
        public int? InvGdsLength { get; set; }
        public int? InvGdsWidth { get; set; }
        public double? InvGdsBurden { get; set; }
        public int? InvGdsHeight { get; set; }
    }
}
