using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDlvrr : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalDlvrr()
        {
            SalInvcH = new HashSet<SalInvcH>();
            SalInvcSrvH = new HashSet<SalInvcSrvH>();
            SalPreInvcH = new HashSet<SalPreInvcH>();
            SalPreInvcSrvH = new HashSet<SalPreInvcSrvH>();
            SalRequestH = new HashSet<SalRequestH>();
        }

        public int SalDlvrrSi { get; set; }
        public string SalDlvrrTp { get; set; }
        public string SalDlvrrTel { get; set; }
        public string SalDlvrrAdrs { get; set; }
        public byte[] SalDlvrrPhoto { get; set; }
        public string SalDlvrrTpEn { get; set; }
        public double? SalDlvrrPercent { get; set; }

        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalInvcSrvH> SalInvcSrvH { get; set; }
        public virtual ICollection<SalPreInvcH> SalPreInvcH { get; set; }
        public virtual ICollection<SalPreInvcSrvH> SalPreInvcSrvH { get; set; }
        public virtual ICollection<SalRequestH> SalRequestH { get; set; }
    }
}
