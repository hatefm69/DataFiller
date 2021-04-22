using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalContractTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalContractTyp()
        {
            SalContractH = new HashSet<SalContractH>();
        }

        public int SalCntrctTypeSi { get; set; }
        public int SalCntrctTypeCu { get; set; }
        public string SalCntrctTypeTp { get; set; }
        public bool? Status { get; set; }
        public int? SalCntrctTypeSiParent { get; set; }

        public virtual ICollection<SalContractH> SalContractH { get; set; }
    }
}
