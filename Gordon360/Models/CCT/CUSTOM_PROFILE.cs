﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    public partial class CUSTOM_PROFILE
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string username { get; set; }
        [Unicode(false)]
        public string calendar { get; set; }
        [Unicode(false)]
        public string facebook { get; set; }
        [Unicode(false)]
        public string twitter { get; set; }
        [Unicode(false)]
        public string instagram { get; set; }
        [Unicode(false)]
        public string linkedin { get; set; }
        [Unicode(false)]
        public string handshake { get; set; }
    }
}