using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalDbFirst.Models
{
    public partial class PatientReport
    {
        public int PatientReportId { get; set; }
        public int? PatientId { get; set; }
        public int? BloodPressure { get; set; }
        public int? Sugar { get; set; }
        public int? Hearbit { get; set; }
        public int? HealthStatus { get; set; }

        public virtual Patient Patient { get; set; }
    }
}