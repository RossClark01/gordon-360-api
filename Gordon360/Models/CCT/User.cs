﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Table("User", Schema = "RecIM")]
    public partial class User
    {
        public User()
        {
            MatchUser = new HashSet<MatchUser>();
            UserLeague = new HashSet<UserLeague>();
            UserStatusHistory = new HashSet<UserStatusHistory>();
            UserTeam = new HashSet<UserTeam>();
        }

        [Key]
        public int ID { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<MatchUser> MatchUser { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserLeague> UserLeague { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserStatusHistory> UserStatusHistory { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserTeam> UserTeam { get; set; }
    }
}