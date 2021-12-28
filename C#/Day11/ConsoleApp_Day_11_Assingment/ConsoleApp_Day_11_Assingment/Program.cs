using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Hospital Management System");
                Console.WriteLine("Select Any one Option");
                Console.WriteLine("\n 1.Insert Doctor " +
                                  "\n 2.Update Doctor " +
                                  "\n 3.Delete Doctor " +
                                  "\n 4.List of Doctors and Patients " +
                                  "\n 5.List of Patients and Medicines" +
                                  "\n 6.Summery Report of Doctor and Patients" +
                                  "\n 7.Exit");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Hospital.addNewDoctor();
                        break;
                    case 2:
                        Hospital.updateDoctor();
                        break;
                    case 3:
                        Hospital.DeleteDoctorDetail();
                        break;
                    case 4:
                        Hospital.GetListOfDoctorPatients();
                        break;
                    case 5:
                        Hospital.GetListOfPatientsMedicine();
                        break;
                    case 6:
                        Hospital.GetSummaryReportofPatient();
                        break;
                    case 7:
                        return;
                    default:
                        break;
                }
            }

        }
    }
}