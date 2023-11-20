﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT;

[Keyless]
public partial class RoomAssign
{
    [Required]
    [StringLength(8)]
    [Unicode(false)]
    public string SESS_CDE { get; set; }

    [Required]
    [StringLength(5)]
    [Unicode(false)]
    public string BLDG_LOC_CDE { get; set; }

    [Required]
    [StringLength(5)]
    [Unicode(false)]
    public string BLDG_CDE { get; set; }

    [Required]
    [StringLength(5)]
    [Unicode(false)]
    public string ROOM_CDE { get; set; }

    public int ROOM_SLOT_NUM { get; set; }

    public int? ID_NUM { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string ROOM_TYPE { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string ROOM_ASSIGN_STS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ASSIGN_DTE { get; set; }
}