using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurQry : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurQrySi { get; set; }
        public string PurQryDt { get; set; }
        public double? PurQryDiscount { get; set; }
        public decimal? PurQryLastPrice { get; set; }
        public decimal? PurQryPrice { get; set; }
        public string PurQryCond { get; set; }
        public string PurQryReciptDt { get; set; }
        public string PurQryKind { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurRqstHSi { get; set; }
        public string PurQryComment { get; set; }
        public string PurQryEndDt { get; set; }
        public string PurQryCu { get; set; }
    }
}
