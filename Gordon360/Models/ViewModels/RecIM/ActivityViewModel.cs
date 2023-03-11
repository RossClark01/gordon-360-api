﻿using Gordon360.Models.CCT;
using Gordon360.Static.Methods;
using System;
using System.Collections.Generic;

namespace Gordon360.Models.ViewModels.RecIM
{
    public class ActivityViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public int SportID { get; set; }
        public int StatusID { get; set; }
        public int MinCapacity { get; set; }
        public int? MaxCapacity { get; set; }
        public bool SoloRegistration { get; set; }
        public string? Logo { get; set; }
        public bool Completed { get; set; }
        public int TypeID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SeriesScheduleID { get; set; }

        public static implicit operator ActivityViewModel(Activity a)
        {
            return new ActivityViewModel
            {
                ID = a.ID,
                Name = a.Name,
                RegistrationStart = Helpers.FormatDateTimeToUtc(a.RegistrationStart),
                RegistrationEnd = Helpers.FormatDateTimeToUtc(a.RegistrationEnd),
                SportID = a.SportID,
                StatusID = a.StatusID,
                MinCapacity = a.MinCapacity,
                MaxCapacity = a.MaxCapacity,
                SoloRegistration = a.SoloRegistration,
                Logo = a.Logo,
                Completed = a.Completed,
                TypeID = a.TypeID,
                StartDate = Helpers.FormatDateTimeToUtc(a.StartDate),
                EndDate = Helpers.FormatDateTimeToUtc(a.EndDate),
                SeriesScheduleID = a.SeriesScheduleID
            };
        }
    }
}