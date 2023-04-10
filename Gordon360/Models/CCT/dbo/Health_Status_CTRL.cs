﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("Health_Status_CTRL", Schema = "dbo")]
    public partial class Health_Status_CTRL
    {
        public Health_Status_CTRL()
        {
            Health_Status = new HashSet<Health_Status>();
        }

        [Key]
        public byte HealthStatusID { get; set; }
        [Required]
        [StringLength(6)]
        [Unicode(false)]
        public string HealthStatusColor { get; set; }

        [InverseProperty("HealthStatus")]
        public virtual ICollection<Health_Status> Health_Status { get; set; }
    }
}