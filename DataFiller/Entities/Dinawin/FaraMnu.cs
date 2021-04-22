using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraMnu : DinawinBaseEntity, IMyEntityDinawin
    {
        public FaraMnu()
        {
            FaraMnuToUsr = new HashSet<FaraMnuToUsr>();
        }

        public int FaraMnuSi { get; set; }
        public string FaraMnuTp { get; set; }
        public int FaraMnuSiParent { get; set; }
        public int? FaraMnuSqnc { get; set; }
        public int? FaraMnuItmSi { get; set; }
        public bool? FaraMnuIsShrt { get; set; }
        public byte[] FaraMnuIcon { get; set; }
        public int? FaraMnuHotKey { get; set; }
        public bool? FaraMnuAutorun { get; set; }
        public bool? FaraMnuHasChild { get; set; }
        public string FaraMnuLicense { get; set; }
        public string FaraMnuTpEn { get; set; }
        public bool? FaraMnuIsIstandard { get; set; }

        public virtual ICollection<FaraMnuToUsr> FaraMnuToUsr { get; set; }
    }
}
