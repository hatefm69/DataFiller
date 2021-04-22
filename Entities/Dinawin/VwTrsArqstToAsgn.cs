using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsArqstToAsgn : DinawinBaseEntity, IMyEntityDinawin
    {
        public double? TrsArqstToAsgnPrc { get; set; }
        public int? SiAccT { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public string TrsArqstToAsgnTp { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string TrsAsgnTp { get; set; }
        public int? TrsArqstSi { get; set; }
        public int? AccLmSi { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
    }
}
