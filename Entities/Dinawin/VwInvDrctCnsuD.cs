using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDrctCnsuD : DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCm { get; set; }
        public int InvDrctCnsuHSi { get; set; }
        public int InvGdsSi { get; set; }
        public double InvDrctCnsuDQty { get; set; }
        public decimal? InvDrctCnsuDUntPrc { get; set; }
        public decimal? InvDrctCnsuDTotal { get; set; }
        public int? PurRqstHSi { get; set; }
        public DateTime? InvDrctCnsuHDt { get; set; }
        public int? CtbCostSi { get; set; }
        public string InvDrctCnsuHPd { get; set; }
        public string InvDrctCnsuHPi { get; set; }
        public string InvDrctCnsuHPc { get; set; }
        public string InvDrctCnsuHPg { get; set; }
        public string CtbCostCu { get; set; }
        public string CtbCostTp { get; set; }
        public int AccLmSi { get; set; }
    }
}
