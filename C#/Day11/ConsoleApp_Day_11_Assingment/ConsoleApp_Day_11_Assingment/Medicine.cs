using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HospitalDbFirst.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            PatientMedicineList = new HashSet<PatientMedicineList>();
        }

        public int MedicineId { get; set; }
        public string MedicineName { get; set; }

        public virtual ICollection<PatientMedicineList> PatientMedicineList { get; set; }
    }
}