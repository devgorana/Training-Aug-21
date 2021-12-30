using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Resident_Sale_Data
{
    public class SqlResidentSaleData : IResidentSaleData
    {
        private ModelContext _modelContext;
        public SqlResidentSaleData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Resident_Sale AddResidentSale(Resident_Sale residentSale)
        {
            _modelContext.Resident_Sales.Add(residentSale);
            _modelContext.SaveChanges();
            return residentSale;
        }

        public void DeleteResidentSale(Resident_Sale residentSale)
        {
            _modelContext.Resident_Sales.Remove(residentSale);
            _modelContext.SaveChanges();
        }

        public Resident_Sale EditResidentSale(Resident_Sale residentSale)
        {
            var existingResidentSaleData = _modelContext.Resident_Sales.Find(residentSale.Resident_Sale_Id);
            if (existingResidentSaleData != null)
            {

                existingResidentSaleData.Apartment_Type = residentSale.Apartment_Type;
                existingResidentSaleData.BHK_Type = residentSale.BHK_Type;
                existingResidentSaleData.Ownership_Type = residentSale.Ownership_Type;
                existingResidentSaleData.Built_Up_Area = residentSale.Built_Up_Area;
                existingResidentSaleData.Carpet_Area = residentSale.Carpet_Area;
                existingResidentSaleData.Property_Age = residentSale.Property_Age;
                existingResidentSaleData.Facing = residentSale.Facing;
                existingResidentSaleData.Floor_Type = residentSale.Floor_Type;
                existingResidentSaleData.Floor = residentSale.Floor;
                existingResidentSaleData.Total_Floor = residentSale.Total_Floor;
                existingResidentSaleData.City = residentSale.City;
                existingResidentSaleData.Locality = residentSale.Locality;
                existingResidentSaleData.Landmark = residentSale.Landmark;
                existingResidentSaleData.Expected_Price = residentSale.Expected_Price;
                existingResidentSaleData.Maintenance_Cost = residentSale.Maintenance_Cost;
                existingResidentSaleData.Available_From = residentSale.Available_From;
                existingResidentSaleData.Kitchen_Type = residentSale.Kitchen_Type;
                existingResidentSaleData.Furnishing = residentSale.Furnishing;
                existingResidentSaleData.Parking = residentSale.Parking;
                existingResidentSaleData.Description = residentSale.Description;
                existingResidentSaleData.Number_Of_Bathrooms = residentSale.Number_Of_Bathrooms;
                existingResidentSaleData.Number_Of_Balcony = residentSale.Number_Of_Balcony;
                existingResidentSaleData.Type_Of_Water_Supply = residentSale.Type_Of_Water_Supply;
                existingResidentSaleData.Gym = residentSale.Gym;
                existingResidentSaleData.Power_Backup = residentSale.Power_Backup;
                existingResidentSaleData.Gated_Security = residentSale.Gated_Security;
                existingResidentSaleData.Who_Will_Show_The_House = residentSale.Who_Will_Show_The_House;
                existingResidentSaleData.Secondary_Number = residentSale.Secondary_Number;

                existingResidentSaleData.Post_Ad = residentSale.Post_Ad;

                _modelContext.Resident_Sales.Update(existingResidentSaleData);
                _modelContext.SaveChanges();
            }
            return residentSale;
            //throw new NotImplementedException();
        }

        public Resident_Sale GetResidentSale(int id)
        {
            var data = _modelContext.Resident_Sales.Find(id);
            return data;
        }

        public List<Resident_Sale> GetResidentSales()
        {
            return _modelContext.Resident_Sales.ToList();
        }
    }
}
