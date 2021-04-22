using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwIntgDbPurchasePursuit : DinawinBaseEntity, IMyEntityDinawin
    {
        public DateTime? PurBuyHDt { get; set; }
        public string Expr1 { get; set; }
        public DateTime? PurOrdBuyHDt { get; set; }
        public string PurOrdBuyHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public int? PurOrderHCu { get; set; }
        public string OrderHProcessDesc { get; set; }
        public DateTime? PurReqstHDt { get; set; }
        public int? PurReqstHCu { get; set; }
        public string PurVndrTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public double? PurReqstDFirstQty { get; set; }
        public double? PurReqstDQty { get; set; }
        public string PurReqstDDt { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurReqstHProcess { get; set; }
        public int? PurReqProcSi { get; set; }
        public string PurReqProcTp { get; set; }
        public int? InvDocTmpHCu { get; set; }
        public string InvDocTmpHDs { get; set; }
        public int? PurReqstHSi { get; set; }
        public double? InvDocTmpDQty { get; set; }
    }
}
