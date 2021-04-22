using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalSeller : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalSellerSi { get; set; }
        public string SalSellerTp { get; set; }
        public string SalSellerEconomicalNo { get; set; }
        public string SalSellerAdress { get; set; }
        public string SalSellerTel { get; set; }
    }
}
