//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gordon360.Models
{
    using System;
    
    public partial class UPCOMING_RIDES_BY_STUDENT_ID_Result
    {
        public string rideID { get; set; }
        public int capacity { get; set; }
        public string destination { get; set; }
        public string meetingPoint { get; set; }
        public System.DateTime startTime { get; set; }
        public System.DateTime endTime { get; set; }
        public byte isCanceled { get; set; }
        public string notes { get; set; }
        public byte isDriver { get; set; }
        public Nullable<int> seatsTaken { get; set; }
    }
}