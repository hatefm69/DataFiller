using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssServiceD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssSrvDSi { get; set; }
        public int AssSrvHSi { get; set; }
        public int? AssInvGdsSi { get; set; }
        public int? AssInvGdsQty1 { get; set; }
        public int? AssInvGdsQty2 { get; set; }
        public string AssInvGdsCu { get; set; }
        public string AssInvGdsTx { get; set; }

        public virtual AssInvGds AssInvGdsSiNavigation { get; set; }
        public virtual AssServiceH AssSrvHSiNavigation { get; set; }
    }
}
