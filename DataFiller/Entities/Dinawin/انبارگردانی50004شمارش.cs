using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class انبارگردانی50004شمارش : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CRow { get; set; }
        public string کدکالا { get; set; }
        public string نامکالا { get; set; }
        public string شمارهفنی { get; set; }
        public string واحد { get; set; }
        public string Title { get; set; }
    }
}
