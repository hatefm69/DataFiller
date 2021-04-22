using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDrctCnsuH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDrctCnsuHSi { get; set; }
        public DateTime? InvDrctCnsuHDt { get; set; }
        public int? CtbCostSi { get; set; }
        public string InvDrctCnsuHPd { get; set; }
        public string InvDrctCnsuHPi { get; set; }
        public string InvDrctCnsuHPc { get; set; }
        public string InvDrctCnsuHPg { get; set; }
        public string CtbCostCu { get; set; }
        public string CtbCostTp { get; set; }
        public int? PerPrsnlSi1 { get; set; }
        public int? PerPrsnlSi2 { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerPrsnlCu2 { get; set; }
        public string PerPrsnlTp2 { get; set; }
        public string DescDriver { get; set; }
        public string BarNumber { get; set; }
        public string InvDrctCnsuHDlvLoc { get; set; }
        public string InvDrctCnsuHDlvBuy { get; set; }
        public string InvDrctCnsuHCarNo { get; set; }
        public int? PurVndrSi { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
    }
}
