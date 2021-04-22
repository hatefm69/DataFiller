using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccExchange : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccExchangeSi { get; set; }
        public DateTime? AccExchangeStartDate { get; set; }
        public DateTime? AccExchangeEndDate { get; set; }
        public double? AccExchangeStartRate { get; set; }
        public double? AccExchangeEndRate { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? AccDocHSi { get; set; }
    }
}
