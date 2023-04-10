﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("SeriesSchedule", Schema = "RecIM")]
    public partial class SeriesSchedule
    {
        public SeriesSchedule()
        {
            Activity = new HashSet<Activity>();
            Series = new HashSet<Series>();
        }

        [Key]
        public int ID { get; set; }
        public bool Sun { get; set; }
        public bool Mon { get; set; }
        public bool Tue { get; set; }
        public bool Wed { get; set; }
        public bool Thu { get; set; }
        public bool Fri { get; set; }
        public bool Sat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        public int? EstMatchTime { get; set; }

        [InverseProperty("SeriesSchedule")]
        public virtual ICollection<Activity> Activity { get; set; }
        [InverseProperty("Schedule")]
        public virtual ICollection<Series> Series { get; set; }
    }
}