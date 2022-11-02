﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("ParticipantActivity", Schema = "RecIM")]
    public partial class ParticipantActivity
    {
        [Key]
        public int ID { get; set; }
        public int ActivityID { get; set; }
        public int ParticipantID { get; set; }
        public int PrivTypeID { get; set; }
        public bool isFreeAgent { get; set; }

        [ForeignKey("ActivityID")]
        [InverseProperty("ParticipantActivity")]
        public virtual Activity Activity { get; set; }
        [ForeignKey("ParticipantID")]
        [InverseProperty("ParticipantActivity")]
        public virtual Participant Participant { get; set; }
        [ForeignKey("PrivTypeID")]
        [InverseProperty("ParticipantActivity")]
        public virtual PrivType PrivType { get; set; }
    }
}