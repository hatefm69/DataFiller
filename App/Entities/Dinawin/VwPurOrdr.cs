using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurOrdr: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurOrdrSi { get; set; }
        public DateTime? PurOrdrDt { get; set; }
        public int InvGdsSi { get; set; }
        public int PurVndrSi { get; set; }
        public double PurOrdrQty { get; set; }
        public decimal PurOrdrUntPrc { get; set; }
        public decimal PurOrdrTotal { get; set; }
        public string PurOrdrTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public byte? PurOrdHcnfrmSi { get; set; }
        public string PurOrdHcnfrmDesc { get; set; }
        public int? PurResPSi { get; set; }
    }
}
