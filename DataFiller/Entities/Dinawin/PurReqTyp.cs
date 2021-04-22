using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurReqTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurReqTypSi { get; set; }
        public string PurReqTypTp { get; set; }
    }
}
