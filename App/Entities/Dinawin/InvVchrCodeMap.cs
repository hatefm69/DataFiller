using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvVchrCodeMap : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvVchrCodeMapId { get; set; }
        public int? AccLmSiSource { get; set; }
        public int? AccLtSiSource { get; set; }
        public int? AccLcSiSource { get; set; }
        public int? AccLpSiSource { get; set; }
        public int? AccLmSiDest { get; set; }
        public int? AccLtSiDest { get; set; }
        public int? AccLcSiDest { get; set; }
        public int? AccLpSiDest { get; set; }

        public virtual CtbCost AccLcSiSourceNavigation { get; set; }
        public virtual CtbAccM AccLmSiSourceNavigation { get; set; }
        public virtual CtbProject AccLpSiSourceNavigation { get; set; }
        public virtual CtbAccT AccLtSiSourceNavigation { get; set; }
    }
}
