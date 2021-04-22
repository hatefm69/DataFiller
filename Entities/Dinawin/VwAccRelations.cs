using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccRelations : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SiAccK { get; set; }
        public int? SiAccM { get; set; }
        public int? SiAccT { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public string CuAccK { get; set; }
        public string CuAccM { get; set; }
        public string CuAccT { get; set; }
        public string CuCost { get; set; }
        public string CuProject { get; set; }
        public int? Nature { get; set; }
    }
}
