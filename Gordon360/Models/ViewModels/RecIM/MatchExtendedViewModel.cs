﻿using Gordon360.Models.CCT;
using System;
using System.Collections.Generic;

namespace Gordon360.Models.ViewModels.RecIM
{
    public class MatchExtendedViewModel
    {
        public int ID { get; set; }
        public IEnumerable<TeamMatchHistoryViewModel> Scores { get; set; }
        public DateTime Time { get; set; }
        public string Surface { get; set; }
        public string Status { get; set; }
        public int SeriesID { get; set; }
        public ActivityExtendedViewModel Activity { get; set; }
        public IEnumerable<ParticipantExtendedViewModel> Attendance { get; set; }
        public IEnumerable<TeamExtendedViewModel> Team { get; set; }
    }
}