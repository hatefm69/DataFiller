using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsPhoto : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public byte[] InvGdsPhotoImage { get; set; }
        public byte[] InvGdsPhotoIcon { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
