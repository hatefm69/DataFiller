using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRelieve : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalRelieveSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalRelieveCu { get; set; }
        public string SalRelieveTp { get; set; }
    }
}
