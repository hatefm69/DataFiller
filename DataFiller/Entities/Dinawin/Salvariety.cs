using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Salvariety : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalvarietySi { get; set; }
        public string SalvarietyCu { get; set; }
        public string SalvarietyTp { get; set; }
    }
}
