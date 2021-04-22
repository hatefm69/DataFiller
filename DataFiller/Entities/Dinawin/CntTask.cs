using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntTask : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntTaskSi { get; set; }
        public int CntContractSi { get; set; }
        public int? CntTaskSiParent { get; set; }
        public string CntTaskTx { get; set; }
        public int? CntTaskProgress { get; set; }
        public string CntTaskStartDate { get; set; }
        public string CntTaskEndDate { get; set; }
        public byte? CntTaskActive { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}
