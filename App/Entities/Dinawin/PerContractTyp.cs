using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerContractTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerContractTypSi { get; set; }
        public string PerContractTypCu { get; set; }
        public string PerContractTypTp { get; set; }
    }
}
