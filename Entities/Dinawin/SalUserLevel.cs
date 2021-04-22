using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalUserLevel : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalUserLevelSi { get; set; }
        public string SalUserLevelUserCode { get; set; }
        public string SalUserLevelUserName { get; set; }
        public int? SalUserLevelSiParent { get; set; }
        public short? LevelNo { get; set; }
    }
}
