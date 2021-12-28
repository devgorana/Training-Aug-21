using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalDbFirst.Models
{
    public partial class Assistent
    {
        public Assistent()
        {
            Patient = new HashSet<Patient>();
        }

        public int AssistentId { get; set; }
        public string AssistentName { get; set; }
        public int? DoctorId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}