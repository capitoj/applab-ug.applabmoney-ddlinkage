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
    
    public partial class PhoneDelivery
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneImei { get; set; }
        public string PhoneImeiDual { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPost { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
    }
}