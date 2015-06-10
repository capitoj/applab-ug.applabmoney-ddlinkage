//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitizingDataAdminWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fine
    {
        public int FineId { get; set; }
        public Nullable<int> FineIdEx { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> ExpectedDate { get; set; }
        public Nullable<bool> IsCleared { get; set; }
        public Nullable<System.DateTime> DateCleared { get; set; }
        public Nullable<int> IssuedInMeetingId { get; set; }
        public Nullable<int> PaidInMeetingId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public Nullable<int> MeetingId { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual Meeting Meeting1 { get; set; }
        public virtual Member Member { get; set; }
        public virtual Meeting Meeting2 { get; set; }
    }
}
