﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gordon360.Models.CCT
{
    public partial class ALL_REQUESTSResult
    {
        public int RequestID { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityDescription { get; set; }
        public int IDNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Participation { get; set; }
        public string ParticipationDescription { get; set; }
        public string SessionCode { get; set; }
        public string SessionDescription { get; set; }
        public string CommentText { get; set; }
        public DateTime DateSent { get; set; }
        public string RequestApproved { get; set; }
    }
}
