﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gordon360.Models.CCT
{
    [Keyless]
    public partial class Student
    {
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string ID { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Title { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Suffix { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string MaidenName { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string NickName { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string OnOffCampus { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string OnCampusBuilding { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string OnCampusRoom { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string OnCampusPhone { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string OnCampusPrivatePhone { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string OnCampusFax { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string OffCampusStreet1 { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string OffCampusStreet2 { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string OffCampusCity { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string OffCampusState { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string OffCampusPostalCode { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string OffCampusCountry { get; set; }
        [StringLength(41)]
        [Unicode(false)]
        public string OffCampusPhone { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string OffCampusFax { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string HomeStreet1 { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string HomeStreet2 { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string HomeCity { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string HomeState { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string HomePostalCode { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string HomeCountry { get; set; }
        [StringLength(41)]
        [Unicode(false)]
        public string HomePhone { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string HomeFax { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Cohort { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Class { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string KeepPrivate { get; set; }
        [StringLength(14)]
        [Unicode(false)]
        public string Barcode { get; set; }
        [StringLength(92)]
        [Unicode(false)]
        public string AdvisorIDs { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Married { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Commuter { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Major { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Major2 { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Major3 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Gender { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string grad_student { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string GradDate { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Minor1 { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Minor2 { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Minor3 { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string MobilePhone { get; set; }
        public int IsMobilePhonePrivate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AD_Username { get; set; }
        public int? show_pic { get; set; }
        public int? preferred_photo { get; set; }
        [StringLength(63)]
        [Unicode(false)]
        public string Country { get; set; }
        [StringLength(45)]
        [Unicode(false)]
        public string BuildingDescription { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Major1Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Major2Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Major3Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Minor1Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Minor2Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Minor3Description { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Mail_Location { get; set; }
        public int? ChapelRequired { get; set; }
        public int? ChapelAttended { get; set; }
    }
}