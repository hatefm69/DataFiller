using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAcs : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CtbAcsSi { get; set; }
        public string CtbAcsCu { get; set; }
        public string CtbAcsTp { get; set; }
        public int? CtbAcsSiParent { get; set; }
        public string CtbAcsGrantScr { get; set; }
        public string CtbAcsDenyScr { get; set; }
        public string CtbAcsRevokeScr { get; set; }
        public string CtbAcsObject { get; set; }
        public string CtbAcsAction { get; set; }
    }
}
