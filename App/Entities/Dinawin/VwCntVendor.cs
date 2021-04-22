using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCntVendor : DinawinBaseEntity, IMyEntityDinawin
    {
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int CntVendorSi { get; set; }
        public int? PurVndrSi { get; set; }
        public short? PurVndrCorporateTyp { get; set; }
        public short? CtbCustVndrTypSi { get; set; }
        public string CtbCustVndrTypTp { get; set; }
    }
}
