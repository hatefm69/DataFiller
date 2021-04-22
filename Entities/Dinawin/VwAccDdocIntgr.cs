using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccDdocIntgr : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CuDocType { get; set; }
        public string TpDocType { get; set; }
        public string CuAccK { get; set; }
        public string TpAccK { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuAccP { get; set; }
        public string TpAccP { get; set; }
        public string CuAccC { get; set; }
        public string TpAccC { get; set; }
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
        public decimal? Remain { get; set; }
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
        public string CuAccGrp { get; set; }
        public string TpAccGrp { get; set; }
        public int? SiAccGrp { get; set; }
        public string TpAcc2 { get; set; }
        public DateTime? TrsDccDt { get; set; }
        public string TrsDccIno { get; set; }
    }
}
