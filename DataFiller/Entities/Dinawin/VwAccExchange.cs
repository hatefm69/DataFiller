using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccExchange : DinawinBaseEntity, IMyEntityDinawin
    {
        public DateTime? AccExchangeStartDate { get; set; }
        public DateTime? AccExchangeEndDate { get; set; }
        public double? AccExchangeStartRate { get; set; }
        public double? AccExchangeEndRate { get; set; }
        public string CtbCurncyTp { get; set; }
        public string CtbCurncyFmt { get; set; }
        public int? CtbCurncySi { get; set; }
        public int AccExchangeSi { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public int AccDoc { get; set; }
    }
}
