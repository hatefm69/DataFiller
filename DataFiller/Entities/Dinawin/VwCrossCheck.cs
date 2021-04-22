using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCrossCheck : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public string TpDoc { get; set; }
        public int? SiDdoc { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string ChequeNumber { get; set; }
        public Guid Uid { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Creator { get; set; }
        public int? VoucherTypeId { get; set; }
        public bool? TemporaryVoucher { get; set; }
        public int IsBeginingVoucher { get; set; }
        public int IsFinalVoucher { get; set; }
    }
}
