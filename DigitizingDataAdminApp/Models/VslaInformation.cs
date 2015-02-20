﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitizingDataAdminApp.Models
{
    public class AllVslaInformation
    {
        public List<VslaInformation> AllVslaList { get; set; }
        public VslaInformation VslaDetails { get; set; }
    
    }
    // Setters and getters for VSLA
    public class VslaInformation
    {
        public int VslaId { get; set; }
        public string VslaCode { get; set; }
        public string VslaName { get; set; }
        public string RegionId { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? DateLinked { get; set; }
        public string PhysicalAddress { get; set; }
        public string VslaPhoneMsisdn { get; set; }
        public string GpsLocation { get; set; }
        public string ContactPerson { get; set; }
        public string PositionInVsla { get; set; }
        public string PhoneNumber { get; set; }
        public int CBT { get; set; }
        public string Status { get; set; }
    }
}