using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccCtbMinfoValue : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccCtbMinfoValueSi { get; set; }
        public int? SiDdoc { get; set; }
        public int? AccCtbMinfoSi { get; set; }
        public string AccCtbMinfoValue1 { get; set; }
        public int? CRow { get; set; }
        public int? SiHdoc { get; set; }

        public virtual AccCtbMinfo AccCtbMinfoSiNavigation { get; set; }
    }
}
