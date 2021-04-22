using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccountSubsidiary : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SubsidiaryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
    }
}
