using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Commercial_Sale_Data
{
    public interface ICommercialSaleData
    {
        List<Commercial_Sale> GetCommercialSales();
        Commercial_Sale GetCommercialSale(int id);
        Commercial_Sale AddCommercialSale(Commercial_Sale commercialSale);
        void DeleteCommercialSale(Commercial_Sale commercialSale);
        Commercial_Sale EditCommercialSale(Commercial_Sale commercialSale);
    }
}
