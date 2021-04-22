using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalContractH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalContractH()
        {
            SalContractD = new HashSet<SalContractD>();
        }

        public int SalContractHSi { get; set; }
        public int? SalContractHCu { get; set; }
        public int? SalContractTypeId { get; set; }
        public int SalCustSi { get; set; }
        public string State { get; set; }
        public string SalContractNumber { get; set; }
        public string SalCntrctHDs { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SalContractTp { get; set; }
        public string SalContractStmpCus { get; set; }
        public DateTime? SalContractStmpCdt { get; set; }
        public string SalContractStmpMus { get; set; }
        public DateTime? SalContractStmpMdt { get; set; }
        public decimal? SalContractPrcSumTotal { get; set; }
        public decimal? SalContractPrcTotal { get; set; }

        public virtual SalContractTyp SalContractType { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual ICollection<SalContractD> SalContractD { get; set; }
    }
}
