using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Flatmates_Rent_Data
{
    public interface IFlatmatesRentData
    {
        List<Flatmates_Rent> GetFlatmatesRents();
        Flatmates_Rent GetFlatmatesRent(int id);
        Flatmates_Rent AddFlatmatesRent(Flatmates_Rent flatmatesRent);
        void DeleteFlatmatesRent(Flatmates_Rent flatmatesRent);
        Flatmates_Rent EditFlatmatesRent(Flatmates_Rent flatmatesRent);
    }
}
