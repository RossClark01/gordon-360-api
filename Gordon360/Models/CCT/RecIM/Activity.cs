﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("Activity", Schema = "RecIM")]
    public partial class Activity
    {
        public Activity()
        {
            ParticipantActivity = new HashSet<ParticipantActivity>();
            Series = new HashSet<Series>();
            Team = new HashSet<Team>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string Name { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string Logo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RegistrationStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RegistrationEnd { get; set; }
        public int SportID { get; set; }
        public int StatusID { get; set; }
        public int MinCapacity { get; set; }
        public int? MaxCapacity { get; set; }
        public bool SoloRegistration { get; set; }
        public bool Completed { get; set; }
        public int TypeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int? SeriesScheduleID { get; set; }
        public int Points { get; set; }
        public int? WinnerID { get; set; }

        [ForeignKey("SeriesScheduleID")]
        [InverseProperty("Activity")]
        public virtual SeriesSchedule SeriesSchedule { get; set; }
        [ForeignKey("SportID")]
        [InverseProperty("Activity")]
        public virtual Sport Sport { get; set; }
        [ForeignKey("StatusID")]
        [InverseProperty("Activity")]
        public virtual ActivityStatus Status { get; set; }
        [ForeignKey("TypeID")]
        [InverseProperty("Activity")]
        public virtual ActivityType Type { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<ParticipantActivity> ParticipantActivity { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<Series> Series { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<Team> Team { get; set; }
    }
}