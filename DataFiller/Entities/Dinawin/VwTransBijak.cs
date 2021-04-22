using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransBijak : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TransBijakHCu { get; set; }
        public string TransBijakHDate { get; set; }
        public DateTime? TransBijakHTime { get; set; }
        public string TransBijakHSender { get; set; }
        public string TransBijakHReceiver { get; set; }
        public string TransBijakHSenderAddrs { get; set; }
        public string TransBijakHReceiverAddrs { get; set; }
        public string TransBijakHTarget { get; set; }
        public string TransBijakHGdsDeliveryLoc { get; set; }
        public string TransBijakHDescription { get; set; }
        public double? TransBijakDWeight { get; set; }
        public short? TransBijakDNumber { get; set; }
        public string TransBijakDGds { get; set; }
        public int? TransBijakDSi { get; set; }
        public bool? TransBijakHLock { get; set; }
        public int? TransBijakHSi { get; set; }
        public string TransBijakDUnit { get; set; }
        public decimal? TransBijakHCarFare5 { get; set; }
        public decimal? TransBijakHCarFare4 { get; set; }
        public decimal? TransBijakHCarFare3 { get; set; }
        public decimal? TransBijakHCarFare2 { get; set; }
        public decimal? TransBijakHCarFare1 { get; set; }
        public string TransBijakDSerial { get; set; }
        public string TransBijakHDescription2 { get; set; }
        public string TransBijakDUnitW { get; set; }
    }
}
