﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT;

[Table("Statistic", Schema = "RecIM")]
public partial class Statistic
{
    [Key]
    public int ID { get; set; }

    public int ParticipantTeamID { get; set; }

    public int Win { get; set; }

    public int Loss { get; set; }

    public double Sportsmanship { get; set; }

    public int TimesRated { get; set; }

    [ForeignKey("ParticipantTeamID")]
    [InverseProperty("Statistic")]
    public virtual ParticipantTeam ParticipantTeam { get; set; }
}