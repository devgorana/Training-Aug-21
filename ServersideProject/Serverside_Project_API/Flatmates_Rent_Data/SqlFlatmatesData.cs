using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Flatmates_Rent_Data
{
    public class SqlFlatmatesData : IFlatmatesRentData
    {
        private ModelContext _modelContext;
        public SqlFlatmatesData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Flatmates_Rent AddFlatmatesRent(Flatmates_Rent flatmatesRent)
        {
            _modelContext.Flatmates_Rents.Add(flatmatesRent);
            _modelContext.SaveChanges();
            return flatmatesRent;
        }

        public void DeleteFlatmatesRent(Flatmates_Rent flatmatesRent)
        {
            _modelContext.Flatmates_Rents.Remove(flatmatesRent);
            _modelContext.SaveChanges();
        }

        public Flatmates_Rent EditFlatmatesRent(Flatmates_Rent flatmatesRent)
        {
            var existingFlatmatesRentData = _modelContext.Flatmates_Rents.Find(flatmatesRent.Flatmates_Rent_Id);
            if (existingFlatmatesRentData != null)
            {
               
                existingFlatmatesRentData.Apartment_Type = flatmatesRent.Apartment_Type;
                existingFlatmatesRentData.BHK_Type = flatmatesRent.BHK_Type;
                existingFlatmatesRentData.Floor = flatmatesRent.Floor;
                existingFlatmatesRentData.Total_Floor = flatmatesRent.Total_Floor;
                existingFlatmatesRentData.Room_Type = flatmatesRent.Room_Type;
                existingFlatmatesRentData.Tenant_Type = flatmatesRent.Tenant_Type;
                existingFlatmatesRentData.Property_Age = flatmatesRent.Property_Age;
                existingFlatmatesRentData.Facing = flatmatesRent.Facing;
                existingFlatmatesRentData.Built_Up_Area = flatmatesRent.Built_Up_Area;
                existingFlatmatesRentData.City = flatmatesRent.City;
                existingFlatmatesRentData.Locality = flatmatesRent.Locality;
                existingFlatmatesRentData.Landmark = flatmatesRent.Landmark;
                existingFlatmatesRentData.Available_For = flatmatesRent.Available_For;
                existingFlatmatesRentData.Expected_Rent = flatmatesRent.Expected_Rent;
                existingFlatmatesRentData.Expected_Deposit = flatmatesRent.Expected_Deposit;
                existingFlatmatesRentData.Rent_Negotiable = flatmatesRent.Rent_Negotiable;
                existingFlatmatesRentData.Monthly_Maintenance = flatmatesRent.Monthly_Maintenance;
                existingFlatmatesRentData.Available_From = flatmatesRent.Available_From;

                existingFlatmatesRentData.Furnishing = flatmatesRent.Furnishing;
                existingFlatmatesRentData.Parking = flatmatesRent.Parking;
                existingFlatmatesRentData.Description = flatmatesRent.Description;
                existingFlatmatesRentData.Number_Of_Bathrooms = flatmatesRent.Number_Of_Bathrooms;
                existingFlatmatesRentData.Number_Of_Balcony = flatmatesRent.Number_Of_Balcony;
                existingFlatmatesRentData.Type_Of_Water_Supply = flatmatesRent.Type_Of_Water_Supply;
                existingFlatmatesRentData.Gym = flatmatesRent.Gym;
                existingFlatmatesRentData.Non_Veg_Allowed = flatmatesRent.Non_Veg_Allowed;
                existingFlatmatesRentData.Gated_Security = flatmatesRent.Gated_Security;
                existingFlatmatesRentData.Who_Will_Show_The_House = flatmatesRent.Who_Will_Show_The_House;
                existingFlatmatesRentData.Secondary_Number = flatmatesRent.Secondary_Number;

                existingFlatmatesRentData.Post_Ad = flatmatesRent.Post_Ad;

                _modelContext.Flatmates_Rents.Update(existingFlatmatesRentData);
                _modelContext.SaveChanges();
            }
            return flatmatesRent;
            //throw new NotImplementedException();
        }

        public Flatmates_Rent GetFlatmatesRent(int id)
        {
            var data = _modelContext.Flatmates_Rents.Find(id);
            return data;
        }

        public List<Flatmates_Rent> GetFlatmatesRents()
        {
            return _modelContext.Flatmates_Rents.ToList();
        }
    }
}
