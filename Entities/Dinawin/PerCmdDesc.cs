using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerCmdDesc : DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerCmdDescTp { get; set; }
    }
}
