using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransTabPrn : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TransTabHCu { get; set; }
        public string TransTabHDate { get; set; }
        public string TransTabHCarTag { get; set; }
        public int? TransBijakHSi { get; set; }
        public string TransBijakHCu { get; set; }
        public string TransBijakHDate { get; set; }
        public string TransBijakHDescription { get; set; }
        public int? DetailCount { get; set; }
        public string TransBijakHSender { get; set; }
        public string TransBijakHReceiver { get; set; }
        public string TransBijakHTarget { get; set; }
        public decimal? TransBijakHCarFare1 { get; set; }
        public decimal? TransBijakHCarFare2 { get; set; }
        public decimal? TransBijakHCarFare3 { get; set; }
        public string TransTabHFromLoc { get; set; }
        public string TransTabHToLoc { get; set; }
        public int? Expr1 { get; set; }
        public int TransTabHSi { get; set; }
        public decimal? TransBijakHCarFare4 { get; set; }
        public decimal? TransBijakHCarFare5 { get; set; }
        public short? TransBijakDNumber { get; set; }
    }
}
