using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvAcsDocD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvAcsDocDSi { get; set; }
        public string UsesRec { get; set; }
        public bool? InvAcsDocDAct1 { get; set; }
        public bool? InvAcsDocDAct2 { get; set; }
    }
}
