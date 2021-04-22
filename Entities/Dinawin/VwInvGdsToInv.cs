using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGdsToInv : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCm { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsGrpSi { get; set; }
        public double? InvGdsQtyReal { get; set; }
        public double? InvGdsQtyVirtual { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public bool? InvGdsPrdGds { get; set; }
        public double? InvGdsQtyMin { get; set; }
        public double? InvGdsQtyMax { get; set; }
        public double? InvGdsQtySafe { get; set; }
        public string InvGdsTechNo { get; set; }
        public int InvInvtSi { get; set; }
        public double InvGdsToInvQtyReal { get; set; }
        public double InvGdsToInvQtyVirtual { get; set; }
        public double InvGdsToInvQtyMin { get; set; }
        public double InvGdsToInvQtyMax { get; set; }
        public double InvGdsToInvQtySafe { get; set; }
        public string InvGdsToInvShelf { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public DateTime? InvGdsDateBirth { get; set; }
        public bool? InvGdsActive { get; set; }
        public string InvGdsIcntryTp { get; set; }
        public double? InvGdsQtySale { get; set; }
        public double? InvGdsToInvQtySale { get; set; }
        public bool? InvGdsActiveSale { get; set; }
        public int? InvGdsToInvTag { get; set; }
        public int? InvGdsIcratrSi { get; set; }
        public string InvGdsIcratrTp { get; set; }
        public string InvGdsIcratrCu { get; set; }
        public int? InvUntSiSale { get; set; }
        public string InvUntCuSale { get; set; }
        public string InvUntTpSale { get; set; }
        public bool? InvInvtIsActive { get; set; }
        public bool? InvInvtIsActiveSale { get; set; }
        public string InvGdsLname { get; set; }
    }
}
