﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gordon360.Models.CCT
{
    public partial class FINALIZATION_GET_FINALIZATION_STATUSResult
    {
        public int UserID { get; set; }
        public string Period { get; set; }
        public bool FinalizationCompleted { get; set; }
        public string RootQuery { get; set; }
        public string BypassApprover { get; set; }
        public DateTime? DateFinalized { get; set; }
        public string IgnoreHoldsApprover { get; set; }
        public DateTime DateInserted { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
