using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Commercial_Rent_Data
{
    public class SqlCommercialRentData : ICommercialRentData
    {
        private ModelContext _modelContext;
        public SqlCommercialRentData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Commercial_Rent AddCommercialRent(Commercial_Rent commercialRent)
        {
            _modelContext.Commercial_Rents.Add(commercialRent);
            _modelContext.SaveChanges();
            return commercialRent;
        }

        public void DeleteCommercialRent(Commercial_Rent commercialRent)
        {
            _modelContext.Commercial_Rents.Remove(commercialRent);
            _modelContext.SaveChanges();
        }


        public Commercial_Rent EditCommercialRent(Commercial_Rent commercialRent)
        {
            var existingCommercialRentData = _modelContext.Commercial_Rents.Find(commercialRent.Commercial_Rent_Id);
            if (existingCommercialRentData != null)
            {
                
                existingCommercialRentData.Property_Type = commercialRent.Property_Type;
                existingCommercialRentData.Building_Type = commercialRent.Building_Type;
                existingCommercialRentData.Age_Of_Property = commercialRent.Age_Of_Property;
                existingCommercialRentData.Floor = commercialRent.Floor;
                existingCommercialRentData.Total_Floor = commercialRent.Total_Floor;
                existingCommercialRentData.Super_Built_Up_Area = commercialRent.Super_Built_Up_Area;
                existingCommercialRentData.Furnishing = commercialRent.Furnishing;
                existingCommercialRentData.Other_Features = commercialRent.Other_Features;
                existingCommercialRentData.City = commercialRent.City;
                existingCommercialRentData.Locality = commercialRent.Locality;
                existingCommercialRentData.Landmark = commercialRent.Landmark;
                existingCommercialRentData.Expected_Rent = commercialRent.Expected_Rent;
                existingCommercialRentData.Rent_Negotiable = commercialRent.Rent_Negotiable;
                existingCommercialRentData.Deposit = commercialRent.Deposit;
                existingCommercialRentData.Lease_Duration_Years = commercialRent.Lease_Duration_Years;
                existingCommercialRentData.Lockin_Period_Years = commercialRent.Lockin_Period_Years;
                existingCommercialRentData.Available_From = commercialRent.Available_From;

                existingCommercialRentData.Ideal_For = commercialRent.Ideal_For;
                existingCommercialRentData.Power_Backup = commercialRent.Power_Backup;
                existingCommercialRentData.Lift = commercialRent.Lift;
                existingCommercialRentData.Parking = commercialRent.Parking;
                existingCommercialRentData.Washroom = commercialRent.Washroom;
                existingCommercialRentData.Water_Storage_Facility = commercialRent.Water_Storage_Facility;
                existingCommercialRentData.Security = commercialRent.Security;
                existingCommercialRentData.Wifi = commercialRent.Wifi;
                
                _modelContext.Commercial_Rents.Update(existingCommercialRentData);
                _modelContext.SaveChanges();
            }
            return commercialRent;
            //throw new NotImplementedException();
        }

        public Commercial_Rent GetCommercialRent(int id)
        {
            var data = _modelContext.Commercial_Rents.Find(id);
            return data;
        }

        public List<Commercial_Rent> GetCommercialRents()
        {
            return _modelContext.Commercial_Rents.ToList();
        }
    }
}
