using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDepend : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDependSi { get; set; }
        public string SalDependTp { get; set; }
        public string SalDependJob { get; set; }
        public string SalDependEmail { get; set; }
        public string SalDependMobile { get; set; }
        public string SalDependTel { get; set; }
        public bool? SalDependIsMain { get; set; }
        public string SalDependDesc { get; set; }
        public int? SalCustSi { get; set; }
        public string SalDependSpecialDayDesc { get; set; }
        public string SalDependSpecialDayDate { get; set; }
        public string SalDependBirthdate { get; set; }
        public bool? SalDependIsVip { get; set; }
        public bool? SalDependActive { get; set; }
        public string SalDependEmail2 { get; set; }

        public virtual SalCust SalCustSiNavigation { get; set; }
    }
}
