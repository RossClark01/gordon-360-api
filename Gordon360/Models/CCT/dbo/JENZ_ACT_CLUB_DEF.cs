﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT;

[Keyless]
public partial class JENZ_ACT_CLUB_DEF
{
    [Required]
    [StringLength(8)]
    [Unicode(false)]
    public string ACT_CDE { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string ACT_DESC { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ACT_TYPE { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string ACT_TYPE_DESC { get; set; }

    public int VPM_IM { get; set; }

    public int VPM_CC { get; set; }

    public int VPM_LS { get; set; }

    public int VPM_LW { get; set; }

    public int VPL_IM { get; set; }

    public int VPL_CC { get; set; }

    public int VPL_LS { get; set; }

    public int VPL_LW { get; set; }
}