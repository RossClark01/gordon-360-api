﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    public partial class Housing_Admins
    {
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string AdminID { get; set; }
    }
}