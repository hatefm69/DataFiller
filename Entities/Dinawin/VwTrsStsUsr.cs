using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsStsUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public short TrsDcTypSi { get; set; }
        public short TrsCtypSi { get; set; }
        public short TrsStsSi { get; set; }
        public string TrsStsTp { get; set; }
        public string TrsStsNsts { get; set; }
        public string TrsDcTypTp { get; set; }
        public string TrsCtypTp { get; set; }
        public string TrsStsNstsTp { get; set; }
        public byte? TrsStsFnSiDebit { get; set; }
        public byte? TrsStsFnSiCredit { get; set; }
        public string TrsStsFnTpDebit { get; set; }
        public string TrsStsFnFnDebit { get; set; }
        public string TrsStsFnTpCredit { get; set; }
        public string TrsStsFnFnCredit { get; set; }
        public int TrsStsTypSi { get; set; }
        public string TrsDcTypTp2 { get; set; }
        public string TrsCtypTp2 { get; set; }
        public string TrsStsTp2 { get; set; }
    }
}
