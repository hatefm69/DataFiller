using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmAccess : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmAccessId { get; set; }
        public int? PmAcessCode { get; set; }
        public string PmAccessDesc { get; set; }
    }
}
