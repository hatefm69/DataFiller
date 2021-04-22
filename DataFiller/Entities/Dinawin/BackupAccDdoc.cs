using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BackupAccDdoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiDdoc { get; set; }
        public double? Row { get; set; }
        public int? SiHdoc { get; set; }
        public int? SiAccK { get; set; }
        public int? SiAccM { get; set; }
        public int? SiAccT { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public int? AccArqstSi { get; set; }
        public string TpDoc { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public DateTime? CreateRec { get; set; }
        public string LoginName { get; set; }
        public string Reference { get; set; }
        public bool ExtrCtrl { get; set; }
        public int? Ino { get; set; }
        public DateTime? Idt { get; set; }
        public double? Iqty { get; set; }
        public double DebitC { get; set; }
        public double CreditC { get; set; }
        public string TpDoc2 { get; set; }
        public int? SiDdocSource { get; set; }
        public string Comment { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public int? AccAdvRSi { get; set; }
        public decimal? Remain { get; set; }
        public int? AccDdocRowBgt { get; set; }
        public int? BgtAssignToPrjSubDetailSi { get; set; }
        public int? BgtAssignToCcostSubDetailSi { get; set; }
        public int? BgtAssignToCcostDetailSi { get; set; }
        public int? BgtAssignToPrjDetailSi { get; set; }
        public int? BgtAssignToCcostSi { get; set; }
        public int? BgtAssignToPrjSi { get; set; }
        public string GuId { get; set; }
        public DateTime? TrsDccDt { get; set; }
        public string TrsDccIno { get; set; }
    }
}
