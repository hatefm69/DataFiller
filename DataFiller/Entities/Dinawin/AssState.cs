using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssState : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AssStateCu { get; set; }
        public string AssStateTp { get; set; }
    }
}
