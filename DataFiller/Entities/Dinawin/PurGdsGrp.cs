using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurGdsGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurGdsGrpSi { get; set; }
        public string PurGdsGrpCu { get; set; }
        public string PurGdsGrpTp { get; set; }
        public int? PurGdsGrpSiParent { get; set; }
    }
}
