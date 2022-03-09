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
    public partial class EmergencyContact
    {
        public int APPID { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AD_Username { get; set; }
        public int SEQ_NUM { get; set; }
        public int ID_NUM { get; set; }
        public int? ID_NUM_EMRG_CNTCT { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string prefix { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string lastname { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string firstname { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string middlename { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string suffix { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string HomePhone { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string HomeExt { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string WorkPhone { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string WorkExr { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string MobilePhone { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string MobileExt { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string notes { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string EmailAddress { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string HomeAddrCode { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string WorkAddrCode { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string MobileAddrCode { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string EmailAddrCode { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string AddressAddrCode { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string relationship { get; set; }
        public int EMRG_PRIORITY { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string addr_1 { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string addr_2 { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string city { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string EMRG_STATE { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string zip { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string country { get; set; }
        [Required]
        public byte[] ApprowVersion { get; set; }
        [StringLength(513)]
        [Unicode(false)]
        public string UserName { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string JobName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobTime { get; set; }
    }
}