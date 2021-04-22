using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssMachinId : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssMachinIdSi { get; set; }
        public DateTime? AssMachinIdSetupDate { get; set; }
        public DateTime? AssMachinIdGaranteeDateS { get; set; }
        public DateTime? AssMachinIdGaranteeDateE { get; set; }
        public string AssMachinIdNote { get; set; }
        public int? AssMachineSi { get; set; }
        public int? AssMachineModelSi { get; set; }
        public int? AssCustSi { get; set; }
        public DateTime? AssMachinIdSaleDate { get; set; }
        public string AssMachineSerial { get; set; }

        public virtual AssCust AssCustSiNavigation { get; set; }
        public virtual AssMachineModel AssMachineModelSiNavigation { get; set; }
        public virtual AssMachine AssMachineSiNavigation { get; set; }
    }
}
