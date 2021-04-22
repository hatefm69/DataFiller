using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccountGeneral : DinawinBaseEntity, IMyEntityDinawin
    {
        public int GeneralId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
    }
}
