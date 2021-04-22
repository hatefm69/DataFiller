using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Zone : DinawinBaseEntity, IMyEntityDinawin
    {
        public double? ShahrCode { get; set; }
        public string Shahr { get; set; }
        public string Ostan { get; set; }
        public double? OstanCode { get; set; }
    }
}
