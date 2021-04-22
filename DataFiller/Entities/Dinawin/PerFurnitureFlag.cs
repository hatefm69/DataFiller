using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerFurnitureFlag : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerFurnitureFlagSi { get; set; }
        public string PerFurnitureFlagCu { get; set; }
        public string PerFurnitureFlagTp { get; set; }
    }
}
