using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvExportPrmD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvExportPrmDSi { get; set; }
        public int? InvExportPrmHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? InvExportPrmDQty { get; set; }
        public int? InvUntSi { get; set; }
        public string InvExportPrmDTp { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? PurchaseSendDetailId { get; set; }

        public virtual InvExportPrmH InvExportPrmHSiNavigation { get; set; }
    }
}
