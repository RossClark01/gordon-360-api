﻿using Gordon360.Models.CCT;
using System;
using System.Collections.Generic;

namespace Gordon360.Models.ViewModels.RecIM
{
    public class CreateSeriesViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ActivityID { get; set; }
        public int TypeID { get; set; }
        public int? numberOfTeamsAdmitted { get; set; }
    }
}