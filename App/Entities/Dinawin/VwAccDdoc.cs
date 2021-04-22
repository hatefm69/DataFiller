using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccDdoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CuDocType { get; set; }
        public string TpDocType { get; set; }
        public string CuAccK { get; set; }
        public string TpAccK { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? SiDocType { get; set; }
        public int? SecCuDoc { get; set; }
        public string TpHdoc { get; set; }
        public int? Nature { get; set; }
        public bool? ConWithAccT { get; set; }
        public bool? ConWithCost { get; set; }
        public bool? ConWithProject { get; set; }
        public bool? TempDoc { get; set; }
        public int SiDdoc { get; set; }
        public double? Row { get; set; }
        public int? SiHdoc { get; set; }
        public int? SiAccK { get; set; }
        public int? SiAccM { get; set; }
        public int? SiAccT { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
        public string TpDoc { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public DateTime? CreateRec { get; set; }
        public string Reference { get; set; }
        public string TpCreator { get; set; }
        public string TpConfirmation { get; set; }
        public string LoginName { get; set; }
        public string TpHdoc2 { get; set; }
        public string TpDoc2 { get; set; }
        public string TpAccK2 { get; set; }
        public string TpAccM2 { get; set; }
        public string TpAccT2 { get; set; }
        public string TpCost2 { get; set; }
        public string TpProject2 { get; set; }
        public int? Ino { get; set; }
        public DateTime? Idt { get; set; }
        public double? Iqty { get; set; }
        public double DebitC { get; set; }
        public double CreditC { get; set; }
        public bool ExtrCtrl { get; set; }
        public int? SiSystem { get; set; }
        public int? SiFather { get; set; }
        public double? ExchangeRate { get; set; }
        public bool? ExchangeFlag { get; set; }
        public bool? RqstCurrncy { get; set; }
        public bool? RqstRfrnc { get; set; }
        public int? CtbCurncySi { get; set; }
        public string CtbCurncyTp { get; set; }
        public int? SiDefinite { get; set; }
        public string TpDefinite { get; set; }
        public int? SiAccGrp { get; set; }
        public string CuAccGrp { get; set; }
        public string TpAccGrp { get; set; }
        public byte? NatureCtrl { get; set; }
        public string TpSystem { get; set; }
        public string TpAcc2 { get; set; }
        public int? AccDdocRowBgt { get; set; }
        public int? IdVocherDate { get; set; }
        public byte? Type { get; set; }
        public int? AccArqstSi { get; set; }
        public DateTime? TrsDccDt { get; set; }
        public string TrsDccIno { get; set; }
        public DateTime? AccHdocStmpCdt { get; set; }
        public string AccHdocStmpTime { get; set; }
        public string AccHdocStmpTimeEdit { get; set; }
        public DateTime? AccHdocStmpMdt { get; set; }
    }
}
