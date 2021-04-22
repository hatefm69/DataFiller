using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransDeliver : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? TransDeliverHCu { get; set; }
        public string TransDeliverHEnterDate { get; set; }
        public string TransDeliverHDeliverDate { get; set; }
        public decimal? TransDeliverHCost { get; set; }
        public int? TransDeliverHDeliverStatus { get; set; }
        public decimal? TransDeliverHCarFare1 { get; set; }
        public decimal? TransDeliverHCarFare2 { get; set; }
        public decimal? TransDeliverHCarFare3 { get; set; }
        public decimal? TransDeliverHCarFare4 { get; set; }
        public decimal? TransDeliverHCarFare5 { get; set; }
        public int TransDeliverHSi { get; set; }
        public bool? TransDeliverHAccDoc { get; set; }
        public decimal? TransDeliverHCareFareSum { get; set; }
        public decimal? TransDeliverHVanCost { get; set; }
        public decimal? TransDeliverHOtherCost { get; set; }
        public decimal? TransDeliverHInventoryCost { get; set; }
        public int? TransCustomerSi { get; set; }
        public int? TransCustomerCu { get; set; }
        public string TransCustomerTp { get; set; }
        public string TransCustomerAddress { get; set; }
        public string TransCustomerTel { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
    }
}
