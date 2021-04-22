using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAssReceiptH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? AssMachineTypCu { get; set; }
        public string AssMachineTypTp { get; set; }
        public int? AssAgencyCu { get; set; }
        public string AssAgencyTp { get; set; }
        public int AssReceiptHSi { get; set; }
        public int AssReceiptHCu { get; set; }
        public string AssReceiptHDate { get; set; }
        public string AssReceiptHGuranteNo { get; set; }
        public string AssReceiptHGuranteDate { get; set; }
        public int? AssReceiptHChassisNo { get; set; }
        public int? AssReceiptHEngineNo { get; set; }
        public int? AssMachineTypSi { get; set; }
        public string AssReceiptHTagNo { get; set; }
        public int? AssReceiptHProductYear { get; set; }
        public int? AssReceiptHCurrentKm { get; set; }
        public int? AssAgencySi { get; set; }
        public bool? AssReceiptHFirstService { get; set; }
        public bool? AssReceiptHGuard { get; set; }
        public bool? AssReceiptHGurantee { get; set; }
        public string AssReceiptHCreatorName { get; set; }
        public string AssReceiptHCreateDate { get; set; }
        public bool? AssReceiptHLock { get; set; }
        public string AssReceiptHAdditionPart { get; set; }
        public string AssReceiptHDescription { get; set; }
        public short? AssReceiptHStatus { get; set; }
        public string AssReceiptHRefDate { get; set; }
        public string AssReceiptHMachineColor { get; set; }
        public int? InvInvtSi { get; set; }
        public string AssReceiptHDriverName { get; set; }
        public int? SalCustSi { get; set; }
        public string InvInvtTp { get; set; }
        public int? InvDocHSi { get; set; }
        public string SalCustTp { get; set; }
        public int? SalCustAccTSi { get; set; }
        public int? SalCustAccMSi { get; set; }
        public string SalCustCu { get; set; }
        public bool? AssReceiptHAccDoc { get; set; }
        public bool? AssReceiptHPrcRcvd { get; set; }
        public decimal? AssReceiptHDisCountSum { get; set; }
        public decimal? AssReceiptHTpriceSum { get; set; }
        public decimal? AssReceiptHPriceSum { get; set; }
        public decimal? AssReceiptHGpriceSum { get; set; }
        public decimal? AssReceiptHOpriceSum { get; set; }
    }
}
