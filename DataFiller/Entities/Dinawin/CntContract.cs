using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntContract : DinawinBaseEntity, IMyEntityDinawin
    {
        public CntContract()
        {
            CntAlert = new HashSet<CntAlert>();
            CntAttachment = new HashSet<CntAttachment>();
            CntGds = new HashSet<CntGds>();
            CntPayment = new HashSet<CntPayment>();
            CntReference = new HashSet<CntReference>();
            CntSrv = new HashSet<CntSrv>();
            CntTask = new HashSet<CntTask>();
            CntTrack = new HashSet<CntTrack>();
        }

        public int CntContractSi { get; set; }
        public string CntContractNumber { get; set; }
        public string CntContractSubject { get; set; }
        public string CntContractText { get; set; }
        public string CntContractDate { get; set; }
        public string CntContractStartDate { get; set; }
        public string CntContractEndDate { get; set; }
        public decimal? CntContractPrice { get; set; }
        public string CntContractDescription { get; set; }
        public int? CntStatusSi { get; set; }
        public int? CntTypSi { get; set; }
        public int? CntGrpSi { get; set; }
        public string CntContractContractors { get; set; }
        public int? CtbCurncySi { get; set; }
        public string CntContractContractorNo { get; set; }
        public string CntContractContractorDate { get; set; }
        public byte[] CntContractFile { get; set; }
        public string CntContractFileName { get; set; }
        public string CntContractProphecyNo { get; set; }
        public string CntContractProphecyDate { get; set; }
        public short? CntContractDayBeforeAlert { get; set; }
        public int? SalCustSi { get; set; }
        public int? PurVendorSi { get; set; }
        public int? CntContractSiOld { get; set; }
        public int? CntSaleAgentSi { get; set; }
        public string CntContractReceiptDate { get; set; }
        public string CntCustStatusCu { get; set; }
        public string CntContractNote2 { get; set; }
        public string CntContractSpecialNote { get; set; }

        public virtual CntGrp CntGrpSiNavigation { get; set; }
        public virtual CntTyp CntTypSiNavigation { get; set; }
        public virtual ICollection<CntAlert> CntAlert { get; set; }
        public virtual ICollection<CntAttachment> CntAttachment { get; set; }
        public virtual ICollection<CntGds> CntGds { get; set; }
        public virtual ICollection<CntPayment> CntPayment { get; set; }
        public virtual ICollection<CntReference> CntReference { get; set; }
        public virtual ICollection<CntSrv> CntSrv { get; set; }
        public virtual ICollection<CntTask> CntTask { get; set; }
        public virtual ICollection<CntTrack> CntTrack { get; set; }
    }
}
