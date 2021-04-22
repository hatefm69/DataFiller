using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerSponserShipD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerSponserShipDSi { get; set; }
        public string PerSponserShipDCu { get; set; }
        public string PerSponserShipDFname { get; set; }
        public string PerSponserShipDLname { get; set; }
        public string PerSponserShipDIdno { get; set; }
        public int? PerSponserShipRelatedSi { get; set; }
        public string PerSponserShipBrtDte { get; set; }
        public string PerSponserShipDInsrncIdno { get; set; }
        public bool? PerSponserShipDRelatedCode { get; set; }
        public int? PerPrsnlSi { get; set; }
        public bool? PerSponserShipDOk { get; set; }
        public int? PerSponserShipDNatCode { get; set; }
        public int? PerSponserShipKasrBimeSi { get; set; }
    }
}
