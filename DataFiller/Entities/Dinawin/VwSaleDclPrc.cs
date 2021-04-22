using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSaleDclPrc: DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDclrPrcHSi { get; set; }
        public int? SalDclrPrcHCu { get; set; }
        public string SalDclrPrcHDs { get; set; }
        public string SalDclrPrcHDm { get; set; }
        public int? InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? SalDclrPrcDQty { get; set; }
        public decimal? SalDclrPrcDUntPrc { get; set; }
        public decimal? SalDclrPrcDUntPrcMin { get; set; }
        public decimal? SalDclrPrcDUntPrcMax { get; set; }
        public string SalCustGrpCu { get; set; }
        public string SalCustGrpTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public int? InvGdsTypSi { get; set; }
        public bool? SalDclrPrcDLckPrc { get; set; }
        public string InvGdsGrpTp { get; set; }
        public string InvGdsTechNo { get; set; }
        public string InvGdsTypTp { get; set; }
        public int? SalDclrPrcDSi { get; set; }
        public bool? SalDclrPrcHStatus { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? InvGdsGrpSi { get; set; }
    }
}
