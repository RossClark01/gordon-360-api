﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT;

[PrimaryKey("EVENT_ID", "GORDON_ID")]
public partial class MYSCHEDULE
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string EVENT_ID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string GORDON_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOCATION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DESCRIPTION { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MON_CDE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TUE_CDE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string WED_CDE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string THU_CDE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FRI_CDE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SAT_CDE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SUN_CDE { get; set; }

    public int? IS_ALLDAY { get; set; }

    public TimeSpan? BEGIN_TIME { get; set; }

    public TimeSpan? END_TIME { get; set; }
}