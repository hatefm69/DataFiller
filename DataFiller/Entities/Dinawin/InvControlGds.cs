using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvControlGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvControlGds()
        {
            InvControlGdsD = new HashSet<InvControlGdsD>();
        }

        public int InvControlGdsSi { get; set; }
        public string InvControlGdsCu { get; set; }
        public int? InvDocTmpHSi { get; set; }
        public int? InvDocTmpDSi { get; set; }
        public double? InvControlGdsAql { get; set; }
        public double? InvControlGdsBulK { get; set; }
        public double? InvControlGdsIncorectQty { get; set; }
        public double? InvControlGdsLackQty { get; set; }
        public string InvControlGdsPrsStudy { get; set; }
        public string InvControlGdsTp { get; set; }
        public int? InvGdsResultSi { get; set; }
        public int? InvControlGdsSts { get; set; }
        public DateTime? InvControlGdsStmpCdt { get; set; }
        public string InvControlGdsStmpMus { get; set; }
        public DateTime? InvControlGdsAcptCdt { get; set; }
        public string InvControlGdsAcptMus { get; set; }
        public string InvControlGdsStmpTim { get; set; }
        public string InvControlGdsAcptTim { get; set; }
        public bool? InvControlGdsSndInv { get; set; }
        public bool? InvControlGdsAcs1 { get; set; }
        public bool? InvControlGdsAcs2 { get; set; }
        public bool? InvControlGdsAccept1 { get; set; }
        public bool? InvControlGdsAccept2 { get; set; }
        public bool? InvControlGdsIsTention { get; set; }
        public double? InvControlGdsQtyAccept1 { get; set; }
        public double? InvControlGdsQtyAccept2 { get; set; }
        public bool? InvControlGdsIsBack { get; set; }
        public double? InvControlGdsQtycancle { get; set; }
        public double? InvControlGdsQty { get; set; }

        public virtual ICollection<InvControlGdsD> InvControlGdsD { get; set; }
    }
}
