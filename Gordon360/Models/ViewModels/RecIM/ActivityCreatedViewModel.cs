﻿using Gordon360.Models.CCT;
using System;
using System.Collections.Generic;

namespace Gordon360.Models.ViewModels.RecIM
{
    public class ActivityCreatedViewModel
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

        public static implicit operator ActivityCreatedViewModel(Activity a)
        {
            return new ActivityCreatedViewModel
            {
                ID = a.ID,
                Name = a.Name,
                RegistrationStart = a.RegistrationStart,
                RegistrationEnd = a.RegistrationEnd,
                SportID = a.SportID,
                StatusID = a.StatusID ?? 1,
                MinCapacity = a.MinCapacity ?? 0,
                MaxCapacity = a.MaxCapacity,
                SoloRegistration = a.SoloRegistration,
                Logo = a.Logo,
                Completed = a.Completed
            };
        }
    }
}