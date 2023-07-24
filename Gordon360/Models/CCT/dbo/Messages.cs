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
    public partial class Messages
    {
        [Required]
        [StringLength(72)]
        [Unicode(false)]
        public string _id { get; set; }
        [Required]
        [StringLength(72)]
        [Unicode(false)]
        public string room_id { get; set; }
        public string text { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime createdAt { get; set; }
        [Required]
        [StringLength(72)]
        [Unicode(false)]
        public string user_id { get; set; }
        public byte[] image { get; set; }
        public byte[] video { get; set; }
        public byte[] audio { get; set; }
        public bool system { get; set; }
        public bool sent { get; set; }
        public bool received { get; set; }
        public bool pending { get; set; }
    }
}