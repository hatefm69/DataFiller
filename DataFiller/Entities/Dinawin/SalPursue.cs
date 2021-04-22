using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalPursue : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalPursueSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalPursueDateEnter { get; set; }
        public string SalPursueDateEdit { get; set; }
        public string SalPursueDatePursue { get; set; }
        public string SalPursueDesc { get; set; }
        public string SalPursueUserSave { get; set; }
        public string SalPursueUserEdit { get; set; }
        public string SalPursueTp { get; set; }
        public byte[] SalPursueFile { get; set; }
        public string SalPursueFileName { get; set; }
        public bool SalPursueHaveFile { get; set; }
        public bool? SalPursueIsFinall { get; set; }
        public string SalPursuePursuitTp { get; set; }
        public bool? SalPursuePursuit { get; set; }
        public string SalPursuePredict { get; set; }
        public string SalPursueChanceSale { get; set; }
        public bool? SalPursueNeedSerach { get; set; }
        public bool? SalPursueNeesSerach { get; set; }
        public bool? SalPursueNeesSearch { get; set; }

        public virtual SalCust SalCustSiNavigation { get; set; }
    }
}
