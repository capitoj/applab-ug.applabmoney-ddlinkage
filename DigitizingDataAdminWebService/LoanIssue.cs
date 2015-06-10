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
    
    public partial class LoanIssue
    {
        public LoanIssue()
        {
            this.LoanRepayments = new HashSet<LoanRepayment>();
        }
    
        public int LoanId { get; set; }
        public Nullable<int> LoanIdEx { get; set; }
        public Nullable<int> LoanNo { get; set; }
        public Nullable<decimal> PrincipalAmount { get; set; }
        public Nullable<decimal> InterestAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateCleared { get; set; }
        public Nullable<System.DateTime> DateDue { get; set; }
        public Nullable<bool> IsCleared { get; set; }
        public Nullable<bool> IsDefaulted { get; set; }
        public Nullable<decimal> TotalRepaid { get; set; }
        public Nullable<bool> IsWrittenOff { get; set; }
        public Nullable<int> MeetingId { get; set; }
        public Nullable<int> MemberId { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<LoanRepayment> LoanRepayments { get; set; }
    }
}
