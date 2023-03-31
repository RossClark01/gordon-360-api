﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Keyless]
    public partial class ChapelEvent
    {
        public int ROWID { get; set; }
        [Required]
        [StringLength(25)]
        public string CHBarEventID { get; set; }
        public int ID_NUM { get; set; }
        [StringLength(14)]
        public string CHBarcode { get; set; }
        [StringLength(10)]
        public string CHEventID { get; set; }
        [StringLength(14)]
        public string CHCheckerID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CHDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CHTime { get; set; }
        [StringLength(1)]
        public string CHSource { get; set; }
        [StringLength(4)]
        public string CHTermCD { get; set; }
        public int? Attended { get; set; }
        public int? Required { get; set; }
        public int? LiveID { get; set; }
    }
}