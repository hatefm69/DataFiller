using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbCost : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbCost()
        {
            AccArqst = new HashSet<AccArqst>();
            AccBudget = new HashSet<AccBudget>();
            AccDdoc = new HashSet<AccDdoc>();
            AstAssetLctn = new HashSet<AstAssetLctn>();
            BgtAssignToCcost = new HashSet<BgtAssignToCcost>();
            BgtChangeCostH = new HashSet<BgtChangeCostH>();
            CtbCost2CtbAccM = new HashSet<CtbCost2CtbAccM>();
            InvDocD = new HashSet<InvDocD>();
            InvGdsAccC = new HashSet<InvGdsAccC>();
            InvInvt = new HashSet<InvInvt>();
            InvVchrCodeMap = new HashSet<InvVchrCodeMap>();
            InvVchrD = new HashSet<InvVchrD>();
            PerCmd = new HashSet<PerCmd>();
            PerVchrD = new HashSet<PerVchrD>();
            PrdcLine = new HashSet<PrdcLine>();
            PrdcStation = new HashSet<PrdcStation>();
            PrdcTraceDprocess = new HashSet<PrdcTraceDprocess>();
            PrdcWorkOrderDprocess = new HashSet<PrdcWorkOrderDprocess>();
            PurRqstH = new HashSet<PurRqstH>();
            SalVchrD = new HashSet<SalVchrD>();
            TrsAcc = new HashSet<TrsAcc>();
            TrsArqst = new HashSet<TrsArqst>();
            TrsAsgn = new HashSet<TrsAsgn>();
            TrsDcA = new HashSet<TrsDcA>();
            TrsVchrD = new HashSet<TrsVchrD>();
        }

        public int SiCost { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? SiFather { get; set; }
        public byte? Type { get; set; }
        public DateTime CreateRec { get; set; }
        public string LoginName { get; set; }
        public string TpCost2 { get; set; }
        public string CuCost2 { get; set; }
        public short? CtbCostTypeSi { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
        public virtual ICollection<AccBudget> AccBudget { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<AstAssetLctn> AstAssetLctn { get; set; }
        public virtual ICollection<BgtAssignToCcost> BgtAssignToCcost { get; set; }
        public virtual ICollection<BgtChangeCostH> BgtChangeCostH { get; set; }
        public virtual ICollection<CtbCost2CtbAccM> CtbCost2CtbAccM { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvGdsAccC> InvGdsAccC { get; set; }
        public virtual ICollection<InvInvt> InvInvt { get; set; }
        public virtual ICollection<InvVchrCodeMap> InvVchrCodeMap { get; set; }
        public virtual ICollection<InvVchrD> InvVchrD { get; set; }
        public virtual ICollection<PerCmd> PerCmd { get; set; }
        public virtual ICollection<PerVchrD> PerVchrD { get; set; }
        public virtual ICollection<PrdcLine> PrdcLine { get; set; }
        public virtual ICollection<PrdcStation> PrdcStation { get; set; }
        public virtual ICollection<PrdcTraceDprocess> PrdcTraceDprocess { get; set; }
        public virtual ICollection<PrdcWorkOrderDprocess> PrdcWorkOrderDprocess { get; set; }
        public virtual ICollection<PurRqstH> PurRqstH { get; set; }
        public virtual ICollection<SalVchrD> SalVchrD { get; set; }
        public virtual ICollection<TrsAcc> TrsAcc { get; set; }
        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
        public virtual ICollection<TrsAsgn> TrsAsgn { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
        public virtual ICollection<TrsVchrD> TrsVchrD { get; set; }
    }
}
