using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsArqst : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsArqst()
        {
            TrsArqstToAsgn = new HashSet<TrsArqstToAsgn>();
        }

        public int TrsArqstSi { get; set; }
        public DateTime TrsArqstDt { get; set; }
        public string TrsArqstSbj { get; set; }
        public int? TrsArqstTypSi { get; set; }
        public decimal TrsArqstPrc { get; set; }
        public string TrsArqstDesc { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? TrsArqstStsSi { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }
        public int? ReferenceNo { get; set; }
        public int? SiSystem { get; set; }
        public int? TrsAsgnSi { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual FaraSystems SiSystemNavigation { get; set; }
        public virtual TrsArqstSts TrsArqstStsSiNavigation { get; set; }
        public virtual TrsArqstTyp TrsArqstTypSiNavigation { get; set; }
        public virtual ICollection<TrsArqstToAsgn> TrsArqstToAsgn { get; set; }
    }
}
