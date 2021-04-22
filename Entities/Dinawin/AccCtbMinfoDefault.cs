using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccCtbMinfoDefault: DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccCtbMinfoDefaultSi { get; set; }
        public int? SiAccM { get; set; }
        public string AccCtbMinfoTp { get; set; }
        public bool? IsInput { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsUnique { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
    }
}
