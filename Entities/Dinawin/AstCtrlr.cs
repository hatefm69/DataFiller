using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstCtrlr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AstCtrlrId { get; set; }
        public string AstCtrlrTx { get; set; }
        public DateTime? AstCtrlrStart { get; set; }
        public DateTime? AstCtrlrFinish { get; set; }
    }
}
