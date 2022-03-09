﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Index(nameof(ACT_CDE), nameof(SESS_CDE), nameof(ID_NUM), Name = "IX_MEMBERSHIP", IsUnique = true)]
    public partial class MEMBERSHIP
    {
        [Key]
        public int MEMBERSHIP_ID { get; set; }
        [Required]
        [StringLength(8)]
        [Unicode(false)]
        public string ACT_CDE { get; set; }
        [Required]
        [StringLength(8)]
        [Unicode(false)]
        public string SESS_CDE { get; set; }
        public int ID_NUM { get; set; }
        [Required]
        [StringLength(5)]
        [Unicode(false)]
        public string PART_CDE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BEGIN_DTE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? END_DTE { get; set; }
        [StringLength(45)]
        [Unicode(false)]
        public string COMMENT_TXT { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string USER_NAME { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string JOB_NAME { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JOB_TIME { get; set; }
        public bool? GRP_ADMIN { get; set; }
        public bool? PRIVACY { get; set; }
    }
}