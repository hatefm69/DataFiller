using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPayer : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPayerSi { get; set; }
        public string Tfn { get; set; }
        public int? MmoadiType { get; set; }
        public string PerPayerModiType { get; set; }
        public string PerPayerFname { get; set; }
        public string PerPayerLname { get; set; }
        public string PerPayerBrnch { get; set; }
        public long? PerPayerTelNumber { get; set; }
        public long? PerPayerCodeTax { get; set; }
        public string PerPayerAddress { get; set; }
        public string PerPayerCompanyName { get; set; }
        public string PerPayerD1meliCode { get; set; }
        public string PerPayerD1fname { get; set; }
        public string PerPayerD1lname { get; set; }
        public string PerPayerD1job { get; set; }
        public string PerPayerD2meliCode { get; set; }
        public string PerPayerD2fname { get; set; }
        public string PerPayerD2lname { get; set; }
        public string PerPayerD2job { get; set; }
        public string PerPayerHtyp { get; set; }
        public int? PerPayerModiTypeIn { get; set; }
        public string PerPayerPostCode { get; set; }
        public int? PerHtypSi { get; set; }
        public string PerPayerIntreNnalCode { get; set; }
    }
}
