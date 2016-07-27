//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitizingDataAdminApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VslaCycle
    {
        public VslaCycle()
        {
            this.Meetings = new HashSet<Meeting>();
        }
    
        public int CycleId { get; set; }
        public Nullable<int> CycleIdEx { get; set; }
        public Nullable<System.DateTime> DateEnded { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string CycleCode { get; set; }
        public Nullable<double> InterestRate { get; set; }
        public Nullable<bool> IsEnded { get; set; }
        public Nullable<int> MaxShareQuantity { get; set; }
        public Nullable<double> MaxStartShare { get; set; }
        public Nullable<double> SharedAmount { get; set; }
        public Nullable<double> SharePrice { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> VslaId { get; set; }
        public Nullable<decimal> MigratedInterest { get; set; }
        public Nullable<decimal> MigratedFines { get; set; }
    
        public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual Vsla Vsla { get; set; }
    }
}