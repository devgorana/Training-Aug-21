using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using HospitalDbFirst.Models;

namespace HospitalDbFirst
{
    class Hospital
    {
        public static void addNewDoctor()
        {
            using (var dbContext = new HospitalDBContext())
            {
                Console.WriteLine("Enter Doctor Name");
                var doctorName = Console.ReadLine();
                var departmentId = 1;

                var newdoctor = new Doctor
                {
                    DoctorName = doctorName,
                    DepartmentId = departmentId
                };
                dbContext.Doctor.Add(newdoctor);
                dbContext.SaveChanges();
                Console.WriteLine("Success");

            }
        }

        public static void updateDoctor()
        {
            using (var dbContext = new HospitalDBContext())
            {
                var getDoctorlist = dbContext.Doctor.ToList();
                Console.WriteLine("List of Doctor:");
                foreach (var doctor in getDoctorlist)
                {
                    Console.WriteLine($"DoctorId:{doctor.DoctorId}  DoctorName : {doctor.DoctorName}");
                }
                Console.WriteLine("Select DoctorId :");
                var doctorId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Doctor Name:");
                var doctorName = Console.ReadLine();
                var doctorDetail = dbContext.Doctor.Where(x => x.DoctorId == doctorId).FirstOrDefault();
                doctorDetail.DoctorName = doctorName;
                dbContext.SaveChanges();
                Console.WriteLine("Update Doctor.");
            }
        }

        public static void DeleteDoctorDetail()
        {
            using (var dbContext = new HospitalDBContext())
            {
                var getDoctorlist = dbContext.Doctor.ToList();
                Console.WriteLine("List of Doctor:");
                foreach (var doctor in getDoctorlist)
                {
                    Console.WriteLine($"DoctorId:{doctor.DoctorId}  DoctorName : {doctor.DoctorName}");
                }
                Console.WriteLine("Select DoctorId :");
                var doctorId = Convert.ToInt32(Console.ReadLine());
                var deleteDoctorId = dbContext.Doctor.Where(x => x.DoctorId == doctorId).FirstOrDefault();
                dbContext.Remove(deleteDoctorId);
                dbContext.SaveChanges();
            }

        }

        public static void GetListOfDoctorPatients()
        {

            Console.WriteLine("Doctor's  Patients List Given Below:");

            using (var dbContext = new HospitalDBContext())
            {
                var result = dbContext.DoctorPatient.ToList();
                foreach (var item in result)
                {
                    Console.WriteLine($"Doctor No. = {item.DoctorId} \n Patients No. = {item.PatientId} \n\n");
                }
            }
        }

        public static void GetListOfPatientsMedicine()
        {

            Console.WriteLine("Patient's Medicine List Given Below:");
            using (var dbContext = new HospitalDBContext())
            {
                var result = dbContext.PatientMedicineList.ToList();
                foreach (var item in result)
                {
                    Console.WriteLine($"Patient No. = {item.PatientId} \n Medicines No. = {item.MedicineId} \n DayPart = {item.DayPart} \n");
                }
            }
        }

        public static void GetSummaryReportofPatient()
        {
            Console.WriteLine("Summary report of Patient");
            using (var dbContext = new HospitalDBContext())
            {
                var result = dbContext.PatientReport.ToList();
                foreach (var items in result)
                {
                    Console.WriteLine("Summary Report");
                    Console.WriteLine($"Patient No. = {items.PatientId}");
                    Console.WriteLine($"Blood Pressure : {items.BloodPressure} Sugar : {items.Sugar}  HeartBeat : {items.Hearbit} ");
                    Console.WriteLine($"Status = {items.HealthStatus} \n\n");
                }
            }
        }

    }
}