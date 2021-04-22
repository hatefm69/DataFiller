using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsArqst : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsArqstSi { get; set; }
        public DateTime TrsArqstDt { get; set; }
        public string TrsArqstSbj { get; set; }
        public int? TrsArqstTypSi { get; set; }
        public decimal TrsArqstPrc { get; set; }
        public string TrsArqstDesc { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? TrsArqstStsSi { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }
        public string TrsArqstTypTp { get; set; }
        public string TrsArqstStsTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public int? TrsAordrSi { get; set; }
        public DateTime? TrsAordrDt { get; set; }
        public int? SiSystem { get; set; }
        public int? ReferenceNo { get; set; }
        public string TpSystem { get; set; }
        public DateTime? TrsDcCDt { get; set; }
        public double? TrsDcCIno { get; set; }
        public string TrsDcCIbnk { get; set; }
        public int? TrsDcCu { get; set; }
        public string TrsDcTypTp { get; set; }
        public string TrsStsTp { get; set; }
        public string TrsCtypTp { get; set; }
        public string TrsRsrcTp { get; set; }
        public int? TrsAsgnSi { get; set; }
        public string TrsAsgnTp { get; set; }
    }
}
