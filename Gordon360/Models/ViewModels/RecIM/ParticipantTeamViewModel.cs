﻿using Gordon360.Models.CCT;
using System;

namespace Gordon360.Models.ViewModels.RecIM
{
    public class ParticipantTeamViewModel
    {
        public int ID { get; set; }
        public int TeamID { get; set; }
        public int ParticipantID { get; set; }
        public DateTime? SignDate { get; set; }
        public int RoleTypeID { get; set; }

        public static implicit operator ParticipantTeamViewModel(ParticipantTeam pt)
        {
            return new ParticipantTeamViewModel
            {
                ID = pt.ID,
                TeamID = pt.TeamID,
                ParticipantID = pt.ParticipantID,
                SignDate = pt.SignDate ?? null,
                RoleTypeID = pt.RoleType,
            };
        }
    }
}
