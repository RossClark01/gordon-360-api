﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("AffiliationPoints", Schema = "RecIM")]
    public partial class AffiliationPoints
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string AffiliationName { get; set; }
        public int ActivityID { get; set; }
        public int? Points { get; set; }

        [ForeignKey("ActivityID")]
        [InverseProperty("AffiliationPoints")]
        public virtual Activity Activity { get; set; }
        [ForeignKey("AffiliationName")]
        [InverseProperty("AffiliationPoints")]
        public virtual Affiliations AffiliationNameNavigation { get; set; }
    }
}