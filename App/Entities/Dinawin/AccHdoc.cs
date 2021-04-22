using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccHdoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccHdoc()
        {
            AccDdoc = new HashSet<AccDdoc>();
            AccDocHattacH = new HashSet<AccDocHattacH>();
            InvVchrH = new HashSet<InvVchrH>();
            PerPyrlPeriod = new HashSet<PerPyrlPeriod>();
            SalVchrH = new HashSet<SalVchrH>();
            TrsVchrH = new HashSet<TrsVchrH>();
        }

        public int SiHdoc { get; set; }
        public int? CuDoc { get; set; }
        public string TpHdoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public string CmDoc { get; set; }
        public bool? TempDoc { get; set; }
        public int? SiDocType { get; set; }
        public int? SecCuDoc { get; set; }
        public int? SiDefinite { get; set; }
        public int? SiSystem { get; set; }
        public string TpCreator { get; set; }
        public string TpConfirmation { get; set; }
        public DateTime? CreateRec { get; set; }
        public string LoginName { get; set; }
        public string TpHdoc2 { get; set; }
        public int? AccLocSi { get; set; }
        public byte? Flag { get; set; }
        public int? SiHdocSource { get; set; }
        public bool? ExchangeDocCtrl { get; set; }
        public bool? ExchangeDocFlag { get; set; }
        public int? IdVocherDate { get; set; }
        public bool? IsLock { get; set; }
        public string UserLock { get; set; }
        public string GuId { get; set; }
        public int? PerLocSi { get; set; }
        public int? MonthH { get; set; }
        public DateTime? AccHdocStmpCdt { get; set; }
        public string AccHdocStmpTime { get; set; }
        public string AccHdocStmpTimeEdit { get; set; }
        public DateTime? AccHdocStmpMdt { get; set; }

        public virtual AccLoc AccLocSiNavigation { get; set; }
        public virtual AccDocDefinite SiDefiniteNavigation { get; set; }
        public virtual AccDocTypes SiDocTypeNavigation { get; set; }
        public virtual FaraSystems SiSystemNavigation { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<AccDocHattacH> AccDocHattacH { get; set; }
        public virtual ICollection<InvVchrH> InvVchrH { get; set; }
        public virtual ICollection<PerPyrlPeriod> PerPyrlPeriod { get; set; }
        public virtual ICollection<SalVchrH> SalVchrH { get; set; }
        public virtual ICollection<TrsVchrH> TrsVchrH { get; set; }
    }
}
