using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraRptList : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiRpt { get; set; }
        public string RptGroup { get; set; }
        public string TpRpt { get; set; }
        public string TpRpt2 { get; set; }
        public string FileName { get; set; }
        public string MacroAfter { get; set; }
        public string MacroBefore { get; set; }
        public string Range { get; set; }
        public string UserGuide { get; set; }
        public bool CloseAfterRep { get; set; }
        public bool Cstm { get; set; }
    }
}
