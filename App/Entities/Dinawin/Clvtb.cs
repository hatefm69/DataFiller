using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Clvtb : DinawinBaseEntity, IMyEntityDinawin
    {
        public decimal? L { get; set; }
        public decimal? R { get; set; }
        public decimal? F { get; set; }
        public decimal? M { get; set; }
        public string SalCustTp { get; set; }
        public decimal? Avgl { get; set; }
        public decimal? Avgr { get; set; }
        public decimal? Avgf { get; set; }
        public decimal? Avgm { get; set; }
        public decimal? Clv { get; set; }
        public string نوعمشتری { get; set; }
        public int? SalCustSi { get; set; }
    }
}
