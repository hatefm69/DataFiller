using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnlD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlSi { get; set; }
        public string PerPrsnlDCm { get; set; }
        public string PerPrsnlDPname { get; set; }
        public string PerPrsnlDIdno { get; set; }
        public string PerPrsnlDIdloc { get; set; }
        public string PerPrsnlDIddte { get; set; }
        public string PerPrsnlDBrtDte { get; set; }
        public bool? PerPrsnlDMarid { get; set; }
        public byte? PerPrsnlDChld { get; set; }
        public string PerPrsnlDSldr { get; set; }
        public string PerPrsnlDEdu { get; set; }
        public string PerPrsnlDEmpDte { get; set; }
        public string PerPrsnlDWrkBgnDte { get; set; }
        public string PerPrsnlDWrkEndDte { get; set; }
        public byte? PerPrsnlDSex { get; set; }
        public bool? PerPrsnlDFrgn { get; set; }
        public string PerPrsnlDEmail { get; set; }
        public string PerPrsnlDUrl { get; set; }
        public string PerPrsnlDTel1 { get; set; }
        public string PerPrsnlDTel2 { get; set; }
        public string PerPrsnlDFax { get; set; }
        public string PerPrsnlDAdrs { get; set; }
        public byte[] PerPrsnlDPhoto { get; set; }
        public string PerPrsnlDBnkName { get; set; }
        public string PerPrsnlDBnkBrnch { get; set; }
        public string PerPrsnlDBnkAccNo { get; set; }
        public string PerPrsnlDBnkAccTyp { get; set; }
        public string InsrncNo { get; set; }
        public string InsrncFname { get; set; }
        public string InsrncLname { get; set; }
        public string InsrncDname { get; set; }
        public string InsrncIdno { get; set; }
        public string InsrncIdplc { get; set; }
        public string InsrncNat { get; set; }
        public string InsrncOcp { get; set; }
        public DateTime? PerPrsnlDBuyBak { get; set; }
        public byte? PerInsrncGrpSi { get; set; }
        public int? AccLtSi { get; set; }
        public string PerPrsnlIdNatCode { get; set; }
        public string InsrncOcpcode { get; set; }
        public string PerPrsnlDMajor { get; set; }
        public string PerPrsnlDUniverCity { get; set; }
        public bool? PerPrsnlNotBimeh { get; set; }
        public int? PerLocSi { get; set; }
        public int? BankAccountNo { get; set; }
        public string PerPrsnlDJobType { get; set; }
        public string PerPrsnlIdPassportCode { get; set; }
        public int? PerPrsnlDHistoryJob { get; set; }
        public string PerPrsnlDPostCode { get; set; }
        public string InsrncOcptp { get; set; }
        public int? PerTaxGrpSi { get; set; }
        public int? PereEducateSi { get; set; }
        public int? PerMajorSi { get; set; }
        public int? PerExemptSi { get; set; }
        public int? PerInterNationalSi { get; set; }
        public int? PerPrsnlDInsureType { get; set; }
        public string PerPrsnlDCountry { get; set; }
        public string PerPrsnlDPlcBrth { get; set; }
        public string PerPrsnlDReligion { get; set; }
        public string PerPrsnlDLiberal { get; set; }
        public string PerPrsnlDTypJob { get; set; }
        public string PerPrsnlDEmpStatus { get; set; }
        public string PerPrsnlDTimeInwar { get; set; }
        public string PerPrsnlDTimeWorkAcc { get; set; }
        public string PerPrsnlDJobPlace { get; set; }
        public int? PerPrsnlDGroupCode { get; set; }
        public string PerPrsnlDIdentityJob { get; set; }
        public int? PerPrsnlDExpert { get; set; }
        public int? PerPrsnlDHome { get; set; }
        public string PerPrsnlDHardCode { get; set; }
        public int? PerInsrnPromiseSi { get; set; }
        public int? PerPrsnlDTypeCmd { get; set; }
        public int? PerPrsnlDSponsorShipNo { get; set; }
        public string PerPrsnlDPost { get; set; }
        public string PerPrsnlDPostName { get; set; }
        public string PerPrsnlDPlaceOffice { get; set; }
        public int? PerPlaceOfficeStatusSi { get; set; }
        public int? PeremployeeStatusSi { get; set; }
        public int? PerPaidTypeSi { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public int? PerVehicleFlagSi { get; set; }
        public int? PerFurnitureFlagSi { get; set; }
        public int? PerCurencySi { get; set; }
        public int? PerContractTypSi { get; set; }
        public string PerInsurnceName { get; set; }

        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual PerInsrncGrp PerInsrncGrpSiNavigation { get; set; }
    }
}
