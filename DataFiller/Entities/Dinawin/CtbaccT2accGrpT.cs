using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbaccT2accGrpT : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiAccT2accGrpT { get; set; }
        public string SiAccT { get; set; }
        public string SiaccTgrp { get; set; }
    }
}
