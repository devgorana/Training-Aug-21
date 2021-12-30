using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Resident_Rent_Data
{
    public interface IResidentRentData
    {
        List<Resident_Rent> GetResidentRents();
        Resident_Rent GetResidentRent(int id);
        Resident_Rent AddResidentRent(Resident_Rent residentRent);
        void DeleteResidentRent(Resident_Rent residentRent);
        Resident_Rent EditResidentRent(Resident_Rent residentRent);
    }
}
