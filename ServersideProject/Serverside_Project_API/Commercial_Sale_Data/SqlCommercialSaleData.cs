using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Commercial_Sale_Data
{
    public class SqlCommercialSaleData : ICommercialSaleData
    {
        private ModelContext _modelContext;
        public SqlCommercialSaleData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Commercial_Sale AddCommercialSale(Commercial_Sale commercialSale)
        {
            _modelContext.Commercial_Sales.Add(commercialSale);
            _modelContext.SaveChanges();
            return commercialSale;
        }

        public void DeleteCommercialSale(Commercial_Sale commercialSale)
        {
            _modelContext.Commercial_Sales.Remove(commercialSale);
            _modelContext.SaveChanges();
        }

        public Commercial_Sale EditCommercialSale(Commercial_Sale commercialSale)
        {
            var existingCommercialSaleData = _modelContext.Commercial_Sales.Find(commercialSale.Commercial_Sale_Id);
            if (existingCommercialSaleData != null)
            {
 
                existingCommercialSaleData.Property_Type = commercialSale.Property_Type;
                existingCommercialSaleData.Building_Type = commercialSale.Building_Type;
                existingCommercialSaleData.Age_Of_Property = commercialSale.Age_Of_Property;
                existingCommercialSaleData.Floor = commercialSale.Floor;
                existingCommercialSaleData.Total_Floor = commercialSale.Total_Floor;
                existingCommercialSaleData.Super_Built_Up_Area = commercialSale.Super_Built_Up_Area;
                existingCommercialSaleData.Furnishing = commercialSale.Furnishing;
                existingCommercialSaleData.Other_Features = commercialSale.Other_Features;
                existingCommercialSaleData.City = commercialSale.City;
                existingCommercialSaleData.Locality = commercialSale.Locality;
                existingCommercialSaleData.Landmark = commercialSale.Landmark;
                existingCommercialSaleData.Expected_Price = commercialSale.Expected_Price;
                existingCommercialSaleData.Price_Negotiable = commercialSale.Price_Negotiable;
                existingCommercialSaleData.Ownership_Type = commercialSale.Ownership_Type;
                existingCommercialSaleData.Available_From = commercialSale.Available_From;

                existingCommercialSaleData.Ideal_For = commercialSale.Ideal_For;
                existingCommercialSaleData.Power_Backup = commercialSale.Power_Backup;
                existingCommercialSaleData.Lift = commercialSale.Lift;
                existingCommercialSaleData.Parking = commercialSale.Parking;
                existingCommercialSaleData.Washroom = commercialSale.Washroom;
                existingCommercialSaleData.Water_Storage_Facility = commercialSale.Water_Storage_Facility;
                existingCommercialSaleData.Security = commercialSale.Security;
                existingCommercialSaleData.Wifi = commercialSale.Wifi;

                existingCommercialSaleData.Post_Ad = commercialSale.Post_Ad;

                _modelContext.Commercial_Sales.Update(existingCommercialSaleData);
                _modelContext.SaveChanges();
            }
            return commercialSale;
            //throw new NotImplementedException();
        }

        public Commercial_Sale GetCommercialSale(int id)
        {
            var data = _modelContext.Commercial_Sales.Find(id);
            return data;
        }

        public List<Commercial_Sale> GetCommercialSales()
        {
            return _modelContext.Commercial_Sales.ToList();
        }
    }
}
