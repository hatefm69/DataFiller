using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransBijakTabDeliver : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TransDeliverHEnterDate { get; set; }
        public int? TransDeliverHDeliverStatus { get; set; }
        public string DeliverRemDate { get; set; }
        public int? TransDriverSi { get; set; }
        public string TransDriverFname { get; set; }
        public string TransDriverLname { get; set; }
        public string TransTabHCu { get; set; }
        public string TransTabHDate { get; set; }
        public string TransTabHCarTag { get; set; }
        public string TransTabHFromLoc { get; set; }
        public string TransTabHToLoc { get; set; }
        public double? TransBijakDWeight { get; set; }
        public short? TransBijakDNumber { get; set; }
        public string TransBijakDGds { get; set; }
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
        public bool? TransBijakHLock { get; set; }
        public string TransDriverFullName { get; set; }
        public int? TransTabHSi { get; set; }
        public int? TransTabDSi { get; set; }
        public int TransBijakHSi { get; set; }
        public int? TransDeliverHCu { get; set; }
        public string TransDeliverHDeliverDate { get; set; }
        public decimal? TransDeliverHCost { get; set; }
        public int? TransBijakDSi { get; set; }
        public int? TransDeliverDSi { get; set; }
        public int? TransDeliverHSi { get; set; }
        public decimal? TransDeliverHCarFare1 { get; set; }
        public decimal? TransDeliverHCarFare2 { get; set; }
        public decimal? TransDeliverHCarFare3 { get; set; }
        public decimal? TransDeliverHCarFare4 { get; set; }
        public decimal? TransDeliverHCarFare5 { get; set; }
        public string TransBijakDUnit { get; set; }
        public bool? TransDeliverHAccDoc { get; set; }
        public decimal? TransDeliverHCareFareSum { get; set; }
        public decimal? TransDeliverHVanCost { get; set; }
        public decimal? TransDeliverHOtherCost { get; set; }
        public decimal? TransDeliverHInventoryCost { get; set; }
        public int? TransCustomerSi { get; set; }
        public string TransDriverCarTag { get; set; }
        public string TransdriverAddress { get; set; }
        public string TransdriverTel { get; set; }
        public decimal? TransBijakHCarFare5 { get; set; }
        public decimal? TransBijakHCarFare4 { get; set; }
        public decimal? TransBijakHCarFare3 { get; set; }
        public decimal? TransBijakHCarFare2 { get; set; }
        public decimal? TransBijakHCarFare1 { get; set; }
        public string TransBijakHReceiverTel { get; set; }
        public int? TransCustomerCu { get; set; }
        public string TransCustomerTp { get; set; }
        public string TransCustomerTel { get; set; }
        public string TransCustomerAddress { get; set; }
        public int? AccTSi { get; set; }
        public int? AccMSi { get; set; }
    }
}
