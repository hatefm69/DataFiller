using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalBenefitInvGdsGrp: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvGdsGrpSi { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public decimal? C { get; set; }
        public double? D { get; set; }
        public double? E { get; set; }
        public int? F { get; set; }
        public double? G { get; set; }
        public double? H { get; set; }
        public double? I { get; set; }
    }
}
