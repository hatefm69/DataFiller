using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAordr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsAordrSi { get; set; }
        public int? TrsAordrTypSi { get; set; }
        public decimal? TrsAordrPrc { get; set; }
        public string TrsAordrDesc { get; set; }
        public int? TrsArqstSi { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }
        public string TrsAordrTypTp { get; set; }
        public DateTime TrsAordrDt { get; set; }
        public int? SiSystem { get; set; }
        public string TpSystem { get; set; }
        public int? ReferenceNo { get; set; }
        public double? Remain { get; set; }
        public int? TrsAsgnSi { get; set; }
    }
}
