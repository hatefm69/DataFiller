using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransTab : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TransTabHCu { get; set; }
        public string TransTabHDate { get; set; }
        public string TransTabHCarTag { get; set; }
        public int TransTabHSi { get; set; }
        public string TransBijakDGds { get; set; }
        public short? TransBijakDNumber { get; set; }
        public double? TransBijakDWeight { get; set; }
        public int? TransTabDSi { get; set; }
        public int? TransBijakDSi { get; set; }
        public string TransBijakHDate { get; set; }
        public string TransBijakHCu { get; set; }
        public int? TransBijakHSi { get; set; }
        public string TransBijakHSender { get; set; }
        public string TransBijakHReceiver { get; set; }
        public int? CountofBijak { get; set; }
        public string TransBijakHDescription { get; set; }
        public int? TransDriverSi { get; set; }
        public string TransTabHToLoc { get; set; }
        public string TransTabHFromLoc { get; set; }
        public string TransBijakHTarget { get; set; }
        public string TransBijakHSenderAddrs { get; set; }
        public string TransBijakHReceiverAddrs { get; set; }
        public string TransBijakHGdsDeliveryLoc { get; set; }
        public decimal? TransBijakHCarFare1 { get; set; }
        public decimal? TransBijakHCarFare2 { get; set; }
        public decimal? TransBijakHCarFare3 { get; set; }
        public decimal? TransBijakHCarFare4 { get; set; }
        public decimal? TransBijakHCarFare5 { get; set; }
    }
}
