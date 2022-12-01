﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("Sport", Schema = "RecIM")]
    public partial class Sport
    {
        public Sport()
        {
            Activity = new HashSet<Activity>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(64)]
        [Unicode(false)]
        public string Name { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string Description { get; set; }
        [Required]
        [StringLength(512)]
        [Unicode(false)]
        public string Rules { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string Logo { get; set; }

        [InverseProperty("Sport")]
        public virtual ICollection<Activity> Activity { get; set; }
    }
}