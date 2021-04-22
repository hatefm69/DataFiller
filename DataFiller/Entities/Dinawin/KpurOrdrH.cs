using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurOrdrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public KpurOrdrH()
        {
            KpurOrdD = new HashSet<KpurOrdD>();
        }

        public int PurOrdrHSi { get; set; }
        public string PurOrdrHCu { get; set; }
        public DateTime? PurOrdrHDt { get; set; }
        public string PurOrdrHDs { get; set; }
        public bool? PurOrdrHOk { get; set; }
        public int? PurRqstHSi { get; set; }
        public int? PurVndrSi { get; set; }
        public int? PurRespSi { get; set; }
        public string PurQryCu { get; set; }
        public string PurOrdrHOfficial { get; set; }

        public virtual ICollection<KpurOrdD> KpurOrdD { get; set; }
    }
}
