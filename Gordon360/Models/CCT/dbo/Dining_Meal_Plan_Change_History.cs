﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT;

[Keyless]
public partial class Dining_Meal_Plan_Change_History
{
    public int ID_NUM { get; set; }

    [Unicode(false)]
    public string OLD_PLAN { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string OLD_PLAN_ID { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string OLD_PLAN_DESC { get; set; }

    [Unicode(false)]
    public string NEW_PLAN { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string NEW_PLAN_ID { get; set; }

    [Unicode(false)]
    public string SESS_CDE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CHANGE_DATE { get; set; }
}