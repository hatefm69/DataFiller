using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerSponserShip: DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerSponserShipDCu { get; set; }
        public string PerSponserShipDFname { get; set; }
        public string PerSponserShipDLname { get; set; }
        public string PerSponserShipDIdno { get; set; }
        public string PerSponserShipDInsrncIdno { get; set; }
        public bool? PerSponserShipDRelatedCode { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string PerSponserShipBrtDte { get; set; }
        public int PerSponserShipRelatedSi { get; set; }
        public string PerSponserShipRelatedTp { get; set; }
        public int? PerSponserShipKasrBimeSi { get; set; }
        public string PerSponserShipKasrBimeTp { get; set; }
        public int PerSponserShipDSi { get; set; }
        public int? CtbCostSi { get; set; }
        public string TpCost { get; set; }
        public string CuCost { get; set; }
        public int? SiCost { get; set; }
    }
}
