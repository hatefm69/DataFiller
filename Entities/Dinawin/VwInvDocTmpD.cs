using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocTmpD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvDocTmpHCu { get; set; }
        public string InvDocTmpHDs { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string InvDocTmpHTp { get; set; }
        public bool? InvDocTmpHSentDoc { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCu { get; set; }
        public int? InvGdsSi { get; set; }
        public double? InvDocTmpDQty { get; set; }
        public decimal? InvDocTmpDPrice { get; set; }
        public decimal? InvDocTmpDTotal { get; set; }
        public string InvDocTmpDTp { get; set; }
        public double? InvDocTmpDQtyAccept { get; set; }
        public double? InvDocTmpDQtyreturn { get; set; }
        public decimal? InvDocTmpDPriceC { get; set; }
        public decimal? InvDocTmpDTotalC { get; set; }
        public double? ExchangeRate { get; set; }
        public bool? InvDevoteQc { get; set; }
        public string InvCostQcTp { get; set; }
        public string InvCostQcCu { get; set; }
        public string InvUntTp { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvDocTmpHSi { get; set; }
        public int? InvDocTmpDSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InvCostQcSi { get; set; }
        public string InvDocTmpHStmpTim { get; set; }
        public int? PurchaseRequestId { get; set; }
        public string InvDocTmpHExpNo { get; set; }
        public string InvDocTmpDExpNo { get; set; }
        public int? PurVndrSi { get; set; }
        public string InvDocTmpHSts { get; set; }
        public int? InvRqstHSi { get; set; }
    }
}
