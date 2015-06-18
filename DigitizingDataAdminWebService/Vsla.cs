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
    
    public partial class Vsla
    {
        public Vsla()
        {
            this.Members = new HashSet<Member>();
            this.VslaDdActivations = new HashSet<VslaDdActivation>();
            this.VslaCycles = new HashSet<VslaCycle>();
        }
    
        public int VslaId { get; set; }
        public string VslaCode { get; set; }
        public string VslaName { get; set; }
        public string VslaPhoneMsisdn { get; set; }
        public string PhysicalAddress { get; set; }
        public string GpsLocation { get; set; }
        public Nullable<System.DateTime> DateRegistered { get; set; }
        public Nullable<System.DateTime> DateLinked { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string ContactPerson { get; set; }
        public string PositionInVsla { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> CBT { get; set; }
        public int Status { get; set; }
        public string BranchName { get; set; }
    
        public virtual Cbt_info Cbt_info { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<VslaDdActivation> VslaDdActivations { get; set; }
        public virtual VslaRegion VslaRegion { get; set; }
        public virtual ICollection<VslaCycle> VslaCycles { get; set; }
    }
}
