using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraMnuItm : DinawinBaseEntity, IMyEntityDinawin
    {
        public int FaraMnuItmSi { get; set; }
        public string FaraMnuItmProc { get; set; }
        public string FaraMnuItmFileName { get; set; }
        public string FaraMnuItmCaption { get; set; }
        public string FaraMnuItmUserGuide { get; set; }
        public string FaraMnuItmSrcUnitName { get; set; }
        public string FaraMnuItmSrcDeclaration { get; set; }
        public string FaraMnuItmParam { get; set; }
    }
}
