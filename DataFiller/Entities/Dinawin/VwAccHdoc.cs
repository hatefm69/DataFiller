using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccHdoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiHdoc { get; set; }
        public int? CuDoc { get; set; }
        public string TpHdoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public string CmDoc { get; set; }
        public bool? TempDoc { get; set; }
        public int? SiDocType { get; set; }
        public int? SecCuDoc { get; set; }
        public int? SiDefinite { get; set; }
        public int? SiSystem { get; set; }
        public string TpCreator { get; set; }
        public string TpConfirmation { get; set; }
        public DateTime? CreateRec { get; set; }
        public string LoginName { get; set; }
        public string TpHdoc2 { get; set; }
        public int? AccLocSi { get; set; }
        public byte? Flag { get; set; }
        public int? SiHdocSource { get; set; }
        public bool? ExchangeDocCtrl { get; set; }
        public bool? ExchangeDocFlag { get; set; }
        public int? IdVocherDate { get; set; }
        public bool? IsLock { get; set; }
        public string UserLock { get; set; }
        public string CuDocType { get; set; }
        public string TpDocType { get; set; }
        public string TpDefinite { get; set; }
        public string TpSystem { get; set; }
        public DateTime? AccHdocStmpCdt { get; set; }
        public string AccHdocStmpTime { get; set; }
        public string AccHdocStmpTimeEdit { get; set; }
        public DateTime? AccHdocStmpMdt { get; set; }
    }
}
