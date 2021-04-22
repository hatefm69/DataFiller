using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbDblinker : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CtbDblinkerBack { get; set; }
        public string CtbDblinkerNext { get; set; }
    }
}
