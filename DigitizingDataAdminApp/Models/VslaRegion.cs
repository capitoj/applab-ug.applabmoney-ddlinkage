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
    
    public partial class VslaRegion
    {
        public VslaRegion()
        {
            this.TechnicalTrainers = new HashSet<TechnicalTrainer>();
            this.Vslas = new HashSet<Vsla>();
        }
    
        public int RegionId { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
    
        public virtual ICollection<TechnicalTrainer> TechnicalTrainers { get; set; }
        public virtual ICollection<Vsla> Vslas { get; set; }
    }
}