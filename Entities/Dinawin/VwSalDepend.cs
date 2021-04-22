using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalDepend: DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public string SalDependTp { get; set; }
        public string SalDependJob { get; set; }
        public string SalDependEmail { get; set; }
        public string SalDependMobile { get; set; }
        public string SalDependTel { get; set; }
        public bool? SalDependIsMain { get; set; }
        public string SalDependDesc { get; set; }
        public int? SalCustSi { get; set; }
    }
}
