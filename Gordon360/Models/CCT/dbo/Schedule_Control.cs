﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("Schedule_Control", Schema = "dbo")]
    public partial class Schedule_Control
    {
        public int IsSchedulePrivate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTimeStamp { get; set; }
        [StringLength(4096)]
        [Unicode(false)]
        public string Description { get; set; }
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string gordon_id { get; set; }
    }
}