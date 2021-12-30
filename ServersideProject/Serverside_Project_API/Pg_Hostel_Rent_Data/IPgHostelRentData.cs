using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Pg_Hostel_Rent_Data
{
    public interface IPgHostelRentData
    {
        List<Pg_Hostel_Rent> GetPgHostelRents();
        Pg_Hostel_Rent GetPgHostelRent(int id);
        Pg_Hostel_Rent AddPgHostelRent(Pg_Hostel_Rent pgHostelRent);
        void DeletePgHostelRent(Pg_Hostel_Rent pgHostelRent);
        Pg_Hostel_Rent EditPgHostelRent(Pg_Hostel_Rent pgHostelRent);
    }
}
