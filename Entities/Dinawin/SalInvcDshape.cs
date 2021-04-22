using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcDshape : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcDshapeId { get; set; }
        public string SalInvcDshapeTx { get; set; }
    }
}
