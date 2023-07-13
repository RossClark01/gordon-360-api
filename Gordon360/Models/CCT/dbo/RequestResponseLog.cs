﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("RequestResponseLog", Schema = "dbo")]
    public partial class RequestResponseLog
    {
        [Key]
        [StringLength(36)]
        [Unicode(false)]
        public string LogID { get; set; }
        [Required]
        [StringLength(15)]
        [Unicode(false)]
        public string ClientIP { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDate { get; set; }
        [Required]
        [StringLength(510)]
        [Unicode(false)]
        public string UserAgent { get; set; }
        [Required]
        [StringLength(63)]
        [Unicode(false)]
        public string RequestHost { get; set; }
        [Required]
        [StringLength(7)]
        [Unicode(false)]
        public string RequestMethod { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string RequestPath { get; set; }
        [StringLength(510)]
        [Unicode(false)]
        public string RequestQuery { get; set; }
        public int ResponseStatus { get; set; }
        public int? ResponseContentLength { get; set; }
    }
}