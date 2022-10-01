﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("SeriesStatus", Schema = "RecIM")]
    public partial class SeriesStatus
    {
        public SeriesStatus()
        {
            Series = new HashSet<Series>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(64)]
        [Unicode(false)]
        public string Description { get; set; }

        [InverseProperty("Status")]
        public virtual ICollection<Series> Series { get; set; }
    }
}