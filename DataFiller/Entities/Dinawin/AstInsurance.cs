using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstInsurance : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AstInsuranceSi { get; set; }
        public string AstAssetId { get; set; }
        public string AstInsuranceCu { get; set; }
        public string AstInsurKindCu { get; set; }
        public string AstInsuranceMan { get; set; }
        public string AstInsuranceOffice { get; set; }
        public DateTime? AstInsuranceDateS { get; set; }
        public DateTime? AstInsuranceDateE { get; set; }
        public decimal? AstInsuranceAmnt { get; set; }

        public virtual AstInsurKind AstInsurKindCuNavigation { get; set; }
    }
}
