using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvRqstTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public byte InvRqstTypSi { get; set; }
        public string InvRqstTypTp { get; set; }
    }
}
