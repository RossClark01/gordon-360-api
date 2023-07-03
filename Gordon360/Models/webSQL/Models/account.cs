﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.webSQL.Models
{
    [Table("account")]
    public partial class account
    {
        [Key]
        public int account_id { get; set; }
        /// <summary>
        /// Active Directory Username
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string AD_Username { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Building { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Room { get; set; }
    }
}