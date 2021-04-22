using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraCfg : DinawinBaseEntity, IMyEntityDinawin
    {
        public string LicenceTo { get; set; }
        public short? DbtimeOut { get; set; }
        public DateTime? DbdateFrom { get; set; }
        public DateTime? DbdateTo { get; set; }
        public string FileThemePath { get; set; }
        public byte[] FileThemeBnry { get; set; }
        public string FileBkGrndPath { get; set; }
        public byte[] FileBkGrndBnry { get; set; }
        public string FolderSys { get; set; }
        public string FolderRptStd { get; set; }
        public string FolderRptCstm { get; set; }
        public string FolderHlp { get; set; }
        public string WebServiceUrm { get; set; }
        public string ThousandSeparator { get; set; }
        public int? CurrencyDecimals { get; set; }
        public short? SystemDateType { get; set; }
        public string FaraPas { get; set; }
        public string PathBackUp { get; set; }
        public bool? CheckPas { get; set; }
    }
}
