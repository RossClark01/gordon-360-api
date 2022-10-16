﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("Team", Schema = "RecIM")]
    public partial class Team
    {
        public Team()
        {
            MatchTeam = new HashSet<MatchTeam>();
            ParticipantTeam = new HashSet<ParticipantTeam>();
            SeriesTeam = new HashSet<SeriesTeam>();
            Sportmanship = new HashSet<Sportmanship>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(64)]
        [Unicode(false)]
        public string Name { get; set; }
        public int Status { get; set; }
        public int ActivityID { get; set; }
        [Required]
        public bool? Private { get; set; }
        public bool Recruiting { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string Logo { get; set; }

        [ForeignKey("ActivityID")]
        [InverseProperty("Team")]
        public virtual Activity Activity { get; set; }
        [ForeignKey("Status")]
        [InverseProperty("Team")]
        public virtual TeamStatus StatusNavigation { get; set; }
        [InverseProperty("Team")]
        public virtual ICollection<MatchTeam> MatchTeam { get; set; }
        [InverseProperty("Team")]
        public virtual ICollection<ParticipantTeam> ParticipantTeam { get; set; }
        [InverseProperty("Team")]
        public virtual ICollection<SeriesTeam> SeriesTeam { get; set; }
        [InverseProperty("Team")]
        public virtual ICollection<Sportmanship> Sportmanship { get; set; }
    }
}