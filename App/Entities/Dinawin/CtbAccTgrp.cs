using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccTgrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiaccTgrp { get; set; }
        public string Cuacc { get; set; }
        public string Tpacc { get; set; }
        public int? SiFather { get; set; }
    }
}
