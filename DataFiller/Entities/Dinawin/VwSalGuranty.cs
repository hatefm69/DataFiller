using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalGuranty : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalGurantyHtyp { get; set; }
        public string SalGurantyHcu { get; set; }
        public string SalGurantyPcu { get; set; }
        public string SalGurantySerial { get; set; }
        public DateTime? SalGurantyBdate { get; set; }
        public DateTime? SalGurantyEdate { get; set; }
        public int SalGurantySi { get; set; }
        public int? SalInvcHCu { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public int? SalCustGrpSi { get; set; }
    }
}
