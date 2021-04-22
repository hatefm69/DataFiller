using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurResp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRespSi { get; set; }
        public string PurRespCu { get; set; }
        public string PurRespTp { get; set; }
        public string FaraUserCu { get; set; }
    }
}
