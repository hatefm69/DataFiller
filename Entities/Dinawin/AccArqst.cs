using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccArqst : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccArqst()
        {
            AccDdoc = new HashSet<AccDdoc>();
        }

        public int AccArqstSi { get; set; }
        public string AccArqstCu { get; set; }
        public DateTime AccArqstDt { get; set; }
        public int? AccRqstTypSi { get; set; }
        public int? AccRqstStsSi { get; set; }
        public double? AccArqstPrc { get; set; }
        public string AccArqstDesc { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }
        public int? AccBudgetSi { get; set; }
        public int? AccLkSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? AccLcSi { get; set; }

        public virtual AccBudget AccBudgetSiNavigation { get; set; }
        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual AccRqstSts AccRqstStsSiNavigation { get; set; }
        public virtual AccRqstTyp AccRqstTypSiNavigation { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
    }
}
