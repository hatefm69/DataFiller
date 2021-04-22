using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwkpurBuyH: DinawinBaseEntity, IMyEntityDinawin
    {
        public string PurRqstHCu { get; set; }
        public string PurRqstHTp { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public int? PurRqstHQryNo { get; set; }
        public string PurRqstHQryTp { get; set; }
        public string PurQryCu { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string PurOrdrHCu { get; set; }
        public DateTime? PurOrdrHDt { get; set; }
        public string PurOrdrHDs { get; set; }
        public int PurOrdrHSi { get; set; }
        public int PurBuyHSi { get; set; }
        public string PurBuyHCu { get; set; }
        public string PurBuyHCm { get; set; }
        public DateTime? PurBuyHDt { get; set; }
        public string PurBuyHVnFno { get; set; }
    }
}
