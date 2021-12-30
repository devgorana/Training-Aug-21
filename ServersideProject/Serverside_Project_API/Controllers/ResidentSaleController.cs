using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Model;
using Serverside_Project_API.Resident_Sale_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentSaleController : ControllerBase
    {
        private IResidentSaleData _residentSaleData;
        public ResidentSaleController(IResidentSaleData residentSaleData)
        {
            _residentSaleData = residentSaleData;
        }

        [HttpGet("get_all_ResidentSaleData")]
        public IActionResult GetResidentSales()
        {
            return Ok(_residentSaleData.GetResidentSales());
        }

        [HttpGet("get_ResidentSaleData/{id}")]
        public IActionResult GetResidentSale(int id)
        {
            var data = _residentSaleData.GetResidentSale(id);
            if (data != null)
            {
                return Ok(_residentSaleData.GetResidentSale(id));
            }

            return NotFound($"ResidentSaleData with Id-{id} was Not Found.");
        }

        [HttpPost("add_ResidentSaleData")]
        public IActionResult GetResidentSale(Resident_Sale residentSale)
        {

            _residentSaleData.AddResidentSale(residentSale);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, residentSale);
        }

        [HttpDelete("delete_ResidentSaleData/{id}")]
        public IActionResult DeleteResidentSale(int id)
        {
            var data = _residentSaleData.GetResidentSale(id);
            if (data != null)
            {
                _residentSaleData.DeleteResidentSale(data);
                return Ok();
            }

            return NotFound($"ResidentSaleData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_ResidentSaleData/{id}")]
        public IActionResult EditResidentSale(int id, Resident_Sale residentSale)
        {
            var existingResidentSaleData = _residentSaleData.GetResidentSale(id);
            if (existingResidentSaleData != null)
            {
                residentSale.Resident_Sale_Id = existingResidentSaleData.Resident_Sale_Id;
                _residentSaleData.EditResidentSale(residentSale);

            }
            return Ok(residentSale);

        }
    }
}
