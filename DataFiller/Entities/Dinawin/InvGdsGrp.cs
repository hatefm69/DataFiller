using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsGrpSi { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public int? InvGdsGrpSiParent { get; set; }
        public bool? IsServiced { get; set; }
    }
}
