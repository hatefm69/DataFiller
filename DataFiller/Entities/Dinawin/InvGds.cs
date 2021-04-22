using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvGds()
        {
            InvBatchNumber = new HashSet<InvBatchNumber>();
            InvCntBatchD = new HashSet<InvCntBatchD>();
            InvCntD = new HashSet<InvCntD>();
            InvDocD = new HashSet<InvDocD>();
            InvDrctCnsuD = new HashSet<InvDrctCnsuD>();
            InvGdsAccC = new HashSet<InvGdsAccC>();
            InvGdsAccP = new HashSet<InvGdsAccP>();
            InvGdsGrant = new HashSet<InvGdsGrant>();
            InvGdsRepGds = new HashSet<InvGdsRepGds>();
            InvGdsToInv = new HashSet<InvGdsToInv>();
            PrdcBom = new HashSet<PrdcBom>();
            PrdcBomd = new HashSet<PrdcBomd>();
            PrdcTraceDinfo = new HashSet<PrdcTraceDinfo>();
            PrdcTraceDmaterial = new HashSet<PrdcTraceDmaterial>();
            PrdcWorkOrderDinfo = new HashSet<PrdcWorkOrderDinfo>();
            PrdcWorkOrderDmaterial = new HashSet<PrdcWorkOrderDmaterial>();
            PurEnqry = new HashSet<PurEnqry>();
            PurInvcD = new HashSet<PurInvcD>();
            PurOrdr = new HashSet<PurOrdr>();
            PurRqstD = new HashSet<PurRqstD>();
            SalContractD = new HashSet<SalContractD>();
            SalDclrPrcD = new HashSet<SalDclrPrcD>();
            SalInvcD = new HashSet<SalInvcD>();
            SalInvcDsrl = new HashSet<SalInvcDsrl>();
            SalPreInvcD = new HashSet<SalPreInvcD>();
            SalRequestD = new HashSet<SalRequestD>();
            SalRetInvcD = new HashSet<SalRetInvcD>();
            SalRetInvcDsrl = new HashSet<SalRetInvcDsrl>();
            SalePreInvoiceDetail = new HashSet<SalePreInvoiceDetail>();
        }

        public int InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsCm { get; set; }
        public int InvUntSi { get; set; }
        public int InvGdsGrpSi { get; set; }
        public string InvGdsTechNo { get; set; }
        public double InvGdsQtyReal { get; set; }
        public double InvGdsQtyVirtual { get; set; }
        public double InvGdsQtyMin { get; set; }
        public double InvGdsQtyMax { get; set; }
        public double InvGdsQtySafe { get; set; }
        public bool InvGdsPrdGds { get; set; }
        public string InvGdsLname { get; set; }
        public int? InvGdsIcntrySi { get; set; }
        public int? InvGdsIcratrSi { get; set; }
        public decimal? InvGdsStdPrc { get; set; }
        public decimal? InvGdsPurchasePrc { get; set; }
        public int? InvUntSiSale { get; set; }
        public decimal? InvGdsSalePrc { get; set; }
        public int? InvUntCount { get; set; }
        public int? InvGdsStatusSi { get; set; }
        public int? Siaccm { get; set; }
        public string InvGdsGrpSiParent { get; set; }
        public int? PurGdsGrpSi { get; set; }
        public decimal? InvGdsPurchasePrcC { get; set; }
        public DateTime? InvGdsDateBirth { get; set; }
        public bool? InvGdsActive { get; set; }
        public double? InvGdsQtySale { get; set; }
        public bool? InvGdsActiveSale { get; set; }
        public bool? InvGdsActiveSerial { get; set; }
        public double? InvGdsQtyMinOrd { get; set; }
        public double? InvGdsQtyBestInWay { get; set; }
        public int? InvGdsCountdayInWay { get; set; }
        public int? SiAccT { get; set; }
        public bool? ShowInWeb { get; set; }
        public int? InvbasketGdsSi { get; set; }
        public int? InvGdsGrpSi2 { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? PlaneNo { get; set; }
        public int? EmployerNo { get; set; }
        public double? InvGdsBurden { get; set; }
        public int? InvGdsHeight { get; set; }
        public int? InvGdsWidth { get; set; }
        public int? InvGdsLength { get; set; }

        public virtual InvGdsPhoto InvGdsPhoto { get; set; }
        public virtual SalGdsAcc SalGdsAcc { get; set; }
        public virtual SalGdsRetAcc SalGdsRetAcc { get; set; }
        public virtual ICollection<InvBatchNumber> InvBatchNumber { get; set; }
        public virtual ICollection<InvCntBatchD> InvCntBatchD { get; set; }
        public virtual ICollection<InvCntD> InvCntD { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvDrctCnsuD> InvDrctCnsuD { get; set; }
        public virtual ICollection<InvGdsAccC> InvGdsAccC { get; set; }
        public virtual ICollection<InvGdsAccP> InvGdsAccP { get; set; }
        public virtual ICollection<InvGdsGrant> InvGdsGrant { get; set; }
        public virtual ICollection<InvGdsRepGds> InvGdsRepGds { get; set; }
        public virtual ICollection<InvGdsToInv> InvGdsToInv { get; set; }
        public virtual ICollection<PrdcBom> PrdcBom { get; set; }
        public virtual ICollection<PrdcBomd> PrdcBomd { get; set; }
        public virtual ICollection<PrdcTraceDinfo> PrdcTraceDinfo { get; set; }
        public virtual ICollection<PrdcTraceDmaterial> PrdcTraceDmaterial { get; set; }
        public virtual ICollection<PrdcWorkOrderDinfo> PrdcWorkOrderDinfo { get; set; }
        public virtual ICollection<PrdcWorkOrderDmaterial> PrdcWorkOrderDmaterial { get; set; }
        public virtual ICollection<PurEnqry> PurEnqry { get; set; }
        public virtual ICollection<PurInvcD> PurInvcD { get; set; }
        public virtual ICollection<PurOrdr> PurOrdr { get; set; }
        public virtual ICollection<PurRqstD> PurRqstD { get; set; }
        public virtual ICollection<SalContractD> SalContractD { get; set; }
        public virtual ICollection<SalDclrPrcD> SalDclrPrcD { get; set; }
        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
        public virtual ICollection<SalInvcDsrl> SalInvcDsrl { get; set; }
        public virtual ICollection<SalPreInvcD> SalPreInvcD { get; set; }
        public virtual ICollection<SalRequestD> SalRequestD { get; set; }
        public virtual ICollection<SalRetInvcD> SalRetInvcD { get; set; }
        public virtual ICollection<SalRetInvcDsrl> SalRetInvcDsrl { get; set; }
        public virtual ICollection<SalePreInvoiceDetail> SalePreInvoiceDetail { get; set; }
    }
}
