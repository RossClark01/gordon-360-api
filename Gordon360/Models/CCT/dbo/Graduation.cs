﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT;

[Keyless]
public partial class Graduation
{
    public int ID_NUM { get; set; }

    [StringLength(4000)]
    public string WHEN_GRAD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string HAS_GRADUATED { get; set; }
}