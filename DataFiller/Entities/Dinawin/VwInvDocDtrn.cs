using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocDtrn : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocDSi { get; set; }
        public int InvDocHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
        public double? InvDocDQty { get; set; }
        public decimal InvDocDPrice { get; set; }
        public decimal InvDocDTotal { get; set; }
        public string InvDocDTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public int? InvDocHCu { get; set; }
        public string InvDocHDs { get; set; }
        public string InvDocHReference { get; set; }
        public bool? InvDocHDefinite { get; set; }
        public int? InvDocTypSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? PurVndrSi { get; set; }
        public string InvDocTypTp { get; set; }
        public string InvDocTypTp2 { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public int? InvGdsGrpSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public double InvDocDQtyOriginal { get; set; }
        public string InvGdsTechNo { get; set; }
        public int? CtbCostSi { get; set; }
        public int? CtbProjectSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? SalCustSi { get; set; }
    }
}
