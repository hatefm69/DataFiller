using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvRqstD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvRqstHSi { get; set; }
        public int? InvRqstHCu { get; set; }
        public DateTime? InvRqstHDt { get; set; }
        public string InvRqstHTp { get; set; }
        public byte InvRqstTypSi { get; set; }
        public int? InvDocHSi { get; set; }
        public int InvRqstDSi { get; set; }
        public double InvRqstDQty { get; set; }
        public string InvRqstDTp { get; set; }
        public int? InvGdsSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? PerPrsnlSi { get; set; }
        public byte? InvRqstStsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double InvGdsQtyReal { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public int InvUntSi { get; set; }
        public string InvRqstStsTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public int? InvGdsTypSi { get; set; }
        public string InvGdsTypTp { get; set; }
        public string InvGdsTechNo { get; set; }
        public bool? InvRqstHLock { get; set; }
        public string InvRqstHStmpCus { get; set; }
        public DateTime? InvRqstHStmpCdt { get; set; }
        public string InvRqstHStmpMus { get; set; }
        public DateTime? InvRqstHStmpMdt { get; set; }
    }
}
