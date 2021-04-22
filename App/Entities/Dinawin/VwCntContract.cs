using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCntContract : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CntContractNumber { get; set; }
        public string CntContractSubject { get; set; }
        public string CntContractText { get; set; }
        public string CntContractDate { get; set; }
        public string CntContractStartDate { get; set; }
        public string CntContractEndDate { get; set; }
        public decimal? CntContractPrice { get; set; }
        public string CntContractDescription { get; set; }
        public string CntContractContractors { get; set; }
        public string CntTypTx { get; set; }
        public int? CntTypSi { get; set; }
        public int? CntGrpSi { get; set; }
        public string CntGrpTx { get; set; }
        public int? CntGrpSiParent { get; set; }
        public int CntContractSi { get; set; }
        public int? CntStatusSi { get; set; }
        public string CntStatusTx { get; set; }
        public int? CtbCurncySi { get; set; }
        public string CtbCurncyTp { get; set; }
        public string CntContractContractorNo { get; set; }
        public string CntLockUserName { get; set; }
        public string CntLockProcessLevelTx { get; set; }
        public bool? CntLockProcessEndLevel { get; set; }
        public short? CntContractDayBeforeAlert { get; set; }
        public double? ContractAmnt { get; set; }
        public string Customer { get; set; }
        public string PurVendor { get; set; }
        public string CntSaleAgentCu { get; set; }
        public string CntSaleAgentTp { get; set; }
        public string CntContractReceiptDate { get; set; }
        public string CntCustStatusCu { get; set; }
        public string CntContractNote2 { get; set; }
        public string CntContractSpecialNote { get; set; }
    }
}
