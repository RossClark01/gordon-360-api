﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("MatchTeam", Schema = "RecIM")]
    public partial class MatchTeam
    {
        [Key]
        public int ID { get; set; }
        public int TeamID { get; set; }
        public int MatchID { get; set; }
        public int StatusID { get; set; }
        public int Score { get; set; }
        public int SportsmanshipScore { get; set; }

        [ForeignKey("MatchID")]
        [InverseProperty("MatchTeam")]
        public virtual Match Match { get; set; }
        [ForeignKey("StatusID")]
        [InverseProperty("MatchTeam")]
        public virtual MatchTeamStatus Status { get; set; }
        [ForeignKey("TeamID")]
        [InverseProperty("MatchTeam")]
        public virtual Team Team { get; set; }
    }
}