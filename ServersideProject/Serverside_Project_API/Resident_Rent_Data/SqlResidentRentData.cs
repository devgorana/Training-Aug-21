using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Resident_Rent_Data
{
    public class SqlResidentRentData : IResidentRentData
    {
        private ModelContext _modelContext;
        public SqlResidentRentData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Resident_Rent AddResidentRent(Resident_Rent residentRent)
        {
            _modelContext.Resident_Rents.Add(residentRent);
            _modelContext.SaveChanges();
            return residentRent;
        }

        public void DeleteResidentRent(Resident_Rent residentRent)
        {
            _modelContext.Resident_Rents.Remove(residentRent);
            _modelContext.SaveChanges();
        }

        public Resident_Rent EditResidentRent(Resident_Rent residentRent)
        {
            var existingResidentRentData = _modelContext.Resident_Rents.Find(residentRent.Resident_Rent_Id);
            if (existingResidentRentData != null)
            {

                existingResidentRentData.Apartment_Type = residentRent.Apartment_Type;
                existingResidentRentData.BHK_Type = residentRent.BHK_Type;
                existingResidentRentData.Floor = residentRent.Floor;
                existingResidentRentData.Total_Floor = residentRent.Total_Floor;
                existingResidentRentData.Property_Age = residentRent.Property_Age;
                existingResidentRentData.Facing = residentRent.Facing;
                existingResidentRentData.Built_Up_Area = residentRent.Built_Up_Area;
                existingResidentRentData.City = residentRent.City;
                existingResidentRentData.Locality = residentRent.Locality;
                existingResidentRentData.Landmark = residentRent.Landmark;
                existingResidentRentData.Available_For = residentRent.Available_For;
                existingResidentRentData.Expected_Rent = residentRent.Expected_Rent;
                existingResidentRentData.Expected_Deposit = residentRent.Expected_Deposit;
                existingResidentRentData.Rent_Negotiable = residentRent.Rent_Negotiable;
                existingResidentRentData.Monthly_Maintenance = residentRent.Monthly_Maintenance;
                existingResidentRentData.Available_From = residentRent.Available_From;
                existingResidentRentData.Preferred_Tenants = residentRent.Preferred_Tenants;
                existingResidentRentData.Furnishing = residentRent.Furnishing;
                existingResidentRentData.Parking = residentRent.Parking;
                existingResidentRentData.Description = residentRent.Description;
                existingResidentRentData.Number_Of_Bathrooms = residentRent.Number_Of_Bathrooms;
                existingResidentRentData.Number_Of_Balcony = residentRent.Number_Of_Balcony;
                existingResidentRentData.Type_Of_Water_Supply = residentRent.Type_Of_Water_Supply;
                existingResidentRentData.Gym = residentRent.Gym;
                existingResidentRentData.Non_Veg_Allowed = residentRent.Non_Veg_Allowed;
                existingResidentRentData.Gated_Security = residentRent.Gated_Security;
                existingResidentRentData.Who_Will_Show_The_House = residentRent.Who_Will_Show_The_House;
                existingResidentRentData.Secondary_Number = residentRent.Secondary_Number;

                existingResidentRentData.Post_Ad = residentRent.Post_Ad;

                _modelContext.Resident_Rents.Update(existingResidentRentData);
                _modelContext.SaveChanges();
            }
            return residentRent;
            //throw new NotImplementedException();
        }

        public Resident_Rent GetResidentRent(int id)
        {
            var data = _modelContext.Resident_Rents.Find(id);
            return data;
        }

        public List<Resident_Rent> GetResidentRents()
        {
            return _modelContext.Resident_Rents.ToList();
        }
    }
}
