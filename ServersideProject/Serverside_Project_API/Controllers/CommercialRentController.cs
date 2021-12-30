using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Commercial_Rent_Data;
using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommercialRentController : ControllerBase
    {
        private ICommercialRentData _commercialRentData;
        public CommercialRentController(ICommercialRentData commercialRentData)
        {
            _commercialRentData = commercialRentData;
        }

        [HttpGet("get_all_CommercialRentData")]
        public IActionResult GetCommercialRents()
        {
            return Ok(_commercialRentData.GetCommercialRents());
        }

        [HttpGet("get_CommercialRentData/{id}")]
        public IActionResult GetCommercialRent(int id)
        {
            var data = _commercialRentData.GetCommercialRent(id);
            if (data != null)
            {
                return Ok(_commercialRentData.GetCommercialRent(id));
            }

            return NotFound($"CommercialRentData with Id-{id} was Not Found.");
        }

        [HttpPost("add_CommercialRentData")]
        public IActionResult GetCommercialRent(Commercial_Rent commercialRent)
        {

            _commercialRentData.AddCommercialRent(commercialRent);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, commercialRent);
        }

        [HttpDelete("delete_CommercialRentData/{id}")]
        public IActionResult DeleteCommercialRent(int id)
        {
            var data = _commercialRentData.GetCommercialRent(id);
            if (data != null)
            {
                _commercialRentData.DeleteCommercialRent(data);
                return Ok();
            }

            return NotFound($"CommercialRentData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_CommercialRentData/{id}")]
        public IActionResult EditCommercialRent(int id, Commercial_Rent commercialRent)
        {
            var existingCommercialRentData = _commercialRentData.GetCommercialRent(id);
            if (existingCommercialRentData != null)
            {
                commercialRent.Commercial_Rent_Id = existingCommercialRentData.Commercial_Rent_Id;
                _commercialRentData.EditCommercialRent(commercialRent);

            }
            return Ok(commercialRent);
            
        }
    }
}
