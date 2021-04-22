using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class GeneralReportVoucher : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? VoucherDetailId { get; set; }
        public DateTime? Date { get; set; }
        public int? VoucherNumber { get; set; }
        public int? VoucherNumber2 { get; set; }
        public double? Row { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GeneralCode { get; set; }
        public string GeneralName { get; set; }
        public string SubsidiaryCode { get; set; }
        public string SubsidiaryName { get; set; }
        public string DetailCode { get; set; }
        public string DetailName { get; set; }
        public string CostCenterCode { get; set; }
        public string CostCenterName { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterParent { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectParent { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public double? DebitC { get; set; }
        public double? CreditC { get; set; }
        public int? VoucherTypeId { get; set; }
        public string VoucherTypeName { get; set; }
        public bool? TemporaryVoucher { get; set; }
        public int VoucherId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string DatePersian { get; set; }
        public int? Nature { get; set; }
        public double? ExchangeRate { get; set; }
        public string Currency { get; set; }
        public int? DetailParent { get; set; }
        public int? DetailId { get; set; }
        public string Reference { get; set; }
        public int? Ino { get; set; }
        public DateTime? Idt { get; set; }
        public double? Iqty { get; set; }
        public string Idtpersian { get; set; }
        public int? SubSystemId { get; set; }
        public string SubSystemName { get; set; }
        public string Creator { get; set; }
    }
}
