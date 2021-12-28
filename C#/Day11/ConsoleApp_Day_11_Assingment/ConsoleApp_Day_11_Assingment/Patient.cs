using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalDbFirst.Models
{
    public partial class Patient
    {
        public Patient()
        {
            DoctorPatient = new HashSet<DoctorPatient>();
            PatientMedicineList = new HashSet<PatientMedicineList>();
            PatientReport = new HashSet<PatientReport>();
        }

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int? AssistentId { get; set; }
        public int? DoctorId { get; set; }

        public virtual Assistent Assistent { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<DoctorPatient> DoctorPatient { get; set; }
        public virtual ICollection<PatientMedicineList> PatientMedicineList { get; set; }
        public virtual ICollection<PatientReport> PatientReport { get; set; }
    }
}