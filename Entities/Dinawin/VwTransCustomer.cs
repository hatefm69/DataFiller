using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransCustomer : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? TransCustomerCu { get; set; }
        public string TransCustomerTp { get; set; }
        public string TransCustomerAddress { get; set; }
        public string TransCustomerTel { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public int TransCustomerSi { get; set; }
    }
}
