using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmOperationDes : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PmOperationDesId { get; set; }
        public string PmoperationDesDesc { get; set; }
        public int? PmOperationDesRefId { get; set; }
    }
}
