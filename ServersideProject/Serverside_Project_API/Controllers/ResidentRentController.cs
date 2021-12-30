using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Model;
using Serverside_Project_API.Resident_Rent_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentRentController : ControllerBase
    {
        private IResidentRentData _residentRentData;
        public ResidentRentController(IResidentRentData residentRentData)
        {
            _residentRentData = residentRentData;
        }

        [HttpGet("get_all_ResidentRentData")]
        public IActionResult GetResidentRents()
        {
            return Ok(_residentRentData.GetResidentRents());
        }

        [HttpGet("get_ResidentRentData/{id}")]
        public IActionResult GetResidentRent(int id)
        {
            var data = _residentRentData.GetResidentRent(id);
            if (data != null)
            {
                return Ok(_residentRentData.GetResidentRent(id));
            }

            return NotFound($"ResidentRentData with Id-{id} was Not Found.");
        }

        [HttpPost("add_ResidentRentData")]
        public IActionResult GetResidentRent(Resident_Rent residentRent)
        {

            _residentRentData.AddResidentRent(residentRent);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, residentRent);
        }

        [HttpDelete("delete_ResidentRentData/{id}")]
        public IActionResult DeleteResidentRent(int id)
        {
            var data = _residentRentData.GetResidentRent(id);
            if (data != null)
            {
                _residentRentData.DeleteResidentRent(data);
                return Ok();
            }

            return NotFound($"ResidentRentData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_ResidentRentData/{id}")]
        public IActionResult EditResidentRent(int id, Resident_Rent residentRent)
        {
            var existingResidentRentData = _residentRentData.GetResidentRent(id);
            if (existingResidentRentData != null)
            {
                residentRent.Resident_Rent_Id = existingResidentRentData.Resident_Rent_Id;
                _residentRentData.EditResidentRent(residentRent);

            }
            return Ok(residentRent);

        }
    }
}
