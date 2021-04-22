using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssPersonel : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssPersonel()
        {
            AssReception = new HashSet<AssReception>();
            AssSrvHprs = new HashSet<AssSrvHprs>();
        }

        public int AssPrsSi { get; set; }
        public string AssPrsCu { get; set; }
        public string AssPrsLname { get; set; }
        public string AssPrsFname { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual ICollection<AssReception> AssReception { get; set; }
        public virtual ICollection<AssSrvHprs> AssSrvHprs { get; set; }
    }
}
