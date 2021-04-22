using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssCust : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssCust()
        {
            AssMachinId = new HashSet<AssMachinId>();
            AssReception = new HashSet<AssReception>();
        }

        public int AssCustSi { get; set; }
        public string AssCustCu { get; set; }
        public string AssCustTp { get; set; }
        public string AssCustTel { get; set; }
        public string AssStateCu { get; set; }
        public string AssTownCu { get; set; }
        public string AstCustAddr { get; set; }
        public string AstCustEconCode { get; set; }
        public string AstCustPostalCode { get; set; }
        public string AstCustNationalCode { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }

        public virtual ICollection<AssMachinId> AssMachinId { get; set; }
        public virtual ICollection<AssReception> AssReception { get; set; }
    }
}
