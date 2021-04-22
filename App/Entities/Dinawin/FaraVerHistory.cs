using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraVerHistory : DinawinBaseEntity, IMyEntityDinawin
    {
        public int FaraVerHistorySi { get; set; }
        public int? Row { get; set; }
        public int? SiSystem { get; set; }
        public string Description { get; set; }
        public string VersionNo { get; set; }
        public string DateDo { get; set; }

        public virtual FaraSystems SiSystemNavigation { get; set; }
    }
}
