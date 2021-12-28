using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalDbFirst.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Assistent = new HashSet<Assistent>();
            DoctorPatient = new HashSet<DoctorPatient>();
            Patient = new HashSet<Patient>();
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Assistent> Assistent { get; set; }
        public virtual ICollection<DoctorPatient> DoctorPatient { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}