using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsAttacH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsAttacHSi { get; set; }
        public string InvGdsAttacHDs { get; set; }
        public string InvGdsAttacHTp { get; set; }
        public string InvGdsAttacHFileName { get; set; }
        public byte[] InvGdsAttacHFile { get; set; }
        public int? InvGdsSi { get; set; }
    }
}
