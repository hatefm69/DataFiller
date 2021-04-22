using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccMtrxReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccMtrxReportSi { get; set; }
        public string AccMtrxReportViewName { get; set; }
        public int? AccMtrxReportCode { get; set; }
        public string AccMtrxReportTx { get; set; }
        public byte[] AccMtrxReportGridStream { get; set; }
        public byte[] AccMtrxReportFilterStream { get; set; }
        public string AccMtrxReportLgn { get; set; }
        public DateTime? AccMtrxReportCdt { get; set; }
        public DateTime? AccMtrxReportMdt { get; set; }
        public bool? AccMtrxReportIsPublic { get; set; }
    }
}
