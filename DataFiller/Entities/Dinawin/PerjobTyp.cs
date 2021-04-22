using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerjobTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerjobTypSi { get; set; }
        public string PerjobTypCu { get; set; }
        public string PerjobTypTp { get; set; }
    }
}
