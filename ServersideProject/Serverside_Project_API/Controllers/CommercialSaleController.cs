using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Commercial_Sale_Data;
using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommercialSaleController : ControllerBase
    {
        private ICommercialSaleData _commercialSaleData;
        public CommercialSaleController(ICommercialSaleData commercialSaleData)
        {
            _commercialSaleData = commercialSaleData;
        }

        [HttpGet("get_all_CommercialSaleData")]
        public IActionResult GetCommercialSales()
        {
            return Ok(_commercialSaleData.GetCommercialSales());
        }

        [HttpGet("get_CommercialSaleData/{id}")]
        public IActionResult GetCommercialSale(int id)
        {
            var data = _commercialSaleData.GetCommercialSale(id);
            if (data != null)
            {
                return Ok(_commercialSaleData.GetCommercialSale(id));
            }

            return NotFound($"CommercialSaleData with Id-{id} was Not Found.");
        }

        [HttpPost("add_CommercialSaleData")]
        public IActionResult GetCommercialSale(Commercial_Sale commercialSale)
        {

            _commercialSaleData.AddCommercialSale(commercialSale);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, commercialSale);
        }

        [HttpDelete("delete_CommercialSaleData/{id}")]
        public IActionResult DeleteCommercialSale(int id)
        {
            var data = _commercialSaleData.GetCommercialSale(id);
            if (data != null)
            {
                _commercialSaleData.DeleteCommercialSale(data);
                return Ok();
            }

            return NotFound($"CommercialSaleData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_CommercialSaleData/{id}")]
        public IActionResult EditCommercialSale(int id, Commercial_Sale commercialSale)
        {
            var existingCommercialSaleData = _commercialSaleData.GetCommercialSale(id);
            if (existingCommercialSaleData != null)
            {
                commercialSale.Commercial_Sale_Id = existingCommercialSaleData.Commercial_Sale_Id;
                _commercialSaleData.EditCommercialSale(commercialSale);

            }
            return Ok(commercialSale);

        }
    }
}
