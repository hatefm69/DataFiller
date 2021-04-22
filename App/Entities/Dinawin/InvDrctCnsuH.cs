using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDrctCnsuH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvDrctCnsuH()
        {
            InvDrctCnsuD = new HashSet<InvDrctCnsuD>();
        }

        public int InvDrctCnsuHSi { get; set; }
        public DateTime? InvDrctCnsuHDt { get; set; }
        public int? CtbCostSi { get; set; }
        public string InvDrctCnsuHPd { get; set; }
        public string InvDrctCnsuHPi { get; set; }
        public string InvDrctCnsuHPc { get; set; }
        public string InvDrctCnsuHPg { get; set; }
        public int? PerPrsnlSi1 { get; set; }
        public int? PerPrsnlSi2 { get; set; }
        public string DescDriver { get; set; }
        public string BarNumber { get; set; }
        public string InvDrctCnsuHDlvLoc { get; set; }
        public string InvDrctCnsuHDlvBuy { get; set; }
        public string InvDrctCnsuHCarNo { get; set; }
        public int? PurVndrSi { get; set; }
        public int? SiProject { get; set; }

        public virtual ICollection<InvDrctCnsuD> InvDrctCnsuD { get; set; }
    }
}
