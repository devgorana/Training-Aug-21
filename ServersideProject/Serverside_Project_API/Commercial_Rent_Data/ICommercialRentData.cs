using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Commercial_Rent_Data
{
    public interface ICommercialRentData
    {
        List<Commercial_Rent> GetCommercialRents();
        Commercial_Rent GetCommercialRent(int id);
        Commercial_Rent AddCommercialRent(Commercial_Rent commercialRent);
        void DeleteCommercialRent(Commercial_Rent commercialRent);
        Commercial_Rent EditCommercialRent(Commercial_Rent commercialRent);
    }
}
