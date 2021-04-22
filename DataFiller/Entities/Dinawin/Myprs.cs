using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Myprs : DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerPrsnlCu { get; set; }
        public string Birthdate { get; set; }
        public string Empdate { get; set; }
    }
}
