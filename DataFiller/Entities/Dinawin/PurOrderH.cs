using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrderH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurOrderH()
        {
            PurOrderD = new HashSet<PurOrderD>();
            PurOrdvndr = new HashSet<PurOrdvndr>();
            PurPreInvcH = new HashSet<PurPreInvcH>();
        }

        public int PurOrderHSi { get; set; }
        public int? PurOrderHCu { get; set; }
        public DateTime? PurOrderHDt { get; set; }
        public string PurOrderHTp { get; set; }
        public int? PurOrderHKindOrd { get; set; }
        public int? PurOrderHProcess { get; set; }
        public int? PurRespSi { get; set; }
        public bool? PurOrderHOk { get; set; }
        public int? PurOrderHBuyKind { get; set; }
        public int? PurReqstHSi { get; set; }
        public int? PurOrderHPayer { get; set; }
        public int? PurOrderHPayKind { get; set; }

        public virtual PurOrdPayKind PurOrderHPayKindNavigation { get; set; }
        public virtual PurOrdPayer PurOrderHPayerNavigation { get; set; }
        public virtual ICollection<PurOrderD> PurOrderD { get; set; }
        public virtual ICollection<PurOrdvndr> PurOrdvndr { get; set; }
        public virtual ICollection<PurPreInvcH> PurPreInvcH { get; set; }
    }
}
