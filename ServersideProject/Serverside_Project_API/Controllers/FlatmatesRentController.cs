using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Flatmates_Rent_Data;
using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatmatesRentController : ControllerBase
    {
        private IFlatmatesRentData _flatmatesRentData;
        public FlatmatesRentController(IFlatmatesRentData flatmatesRentData)
        {
            _flatmatesRentData = flatmatesRentData;
        }

        [HttpGet("get_all_FlatmatesRentData")]
        public IActionResult GetFlatmatesRents()
        {
            return Ok(_flatmatesRentData.GetFlatmatesRents());
        }

        [HttpGet("get_FlatmatesRentData/{id}")]
        public IActionResult GetFlatmatesRent(int id)
        {
            var data = _flatmatesRentData.GetFlatmatesRent(id);
            if (data != null)
            {
                return Ok(_flatmatesRentData.GetFlatmatesRent(id));
            }

            return NotFound($"FlatmatesRentData with Id-{id} was Not Found.");
        }

        [HttpPost("add_FlatmatesRentData")]
        public IActionResult GetFlatmatesRent(Flatmates_Rent flatmatesRent)
        {

            _flatmatesRentData.AddFlatmatesRent(flatmatesRent);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, flatmatesRent);
        }

        [HttpDelete("delete_FlatmatesRentData/{id}")]
        public IActionResult DeleteFlatmatesRent(int id)
        {
            var data = _flatmatesRentData.GetFlatmatesRent(id);
            if (data != null)
            {
                _flatmatesRentData.DeleteFlatmatesRent(data);
                return Ok();
            }

            return NotFound($"FlatmatesRentData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_FlatmatesRentData/{id}")]
        public IActionResult EditFlatmatesRent(int id, Flatmates_Rent flatmatesRent)
        {
            var existingFlatmatesRentData = _flatmatesRentData.GetFlatmatesRent(id);
            if (existingFlatmatesRentData != null)
            {
                flatmatesRent.Flatmates_Rent_Id = existingFlatmatesRentData.Flatmates_Rent_Id;
                _flatmatesRentData.EditFlatmatesRent(flatmatesRent);

            }
            return Ok(flatmatesRent);

        }
    }
}
