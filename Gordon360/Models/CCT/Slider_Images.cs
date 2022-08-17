﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    public partial class Slider_Images
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Path { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string Title { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string LinkURL { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int SortOrder { get; set; }
    }
}