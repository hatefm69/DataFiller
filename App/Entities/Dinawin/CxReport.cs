using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CxReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CxReportSi { get; set; }
        public string CxReportCu { get; set; }
        public string CxReportTp { get; set; }
        public DateTime CxReportDate { get; set; }
        public string CxReportUser { get; set; }
        public string CxReportIniFile { get; set; }
        public string CxReportGrp { get; set; }
    }
}
