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
    public partial class Health_Question
    {
        [Required]
        [Unicode(false)]
        public string Question { get; set; }
        [Required]
        [Unicode(false)]
        public string YesPrompt { get; set; }
        [Required]
        [Unicode(false)]
        public string NoPrompt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
    }
}