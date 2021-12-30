using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Model;
using Serverside_Project_API.Pg_Hostel_Rent_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PgHostelRentController : ControllerBase
    {
        private IPgHostelRentData _pgHostelRentData;
        public PgHostelRentController(IPgHostelRentData pgHostelRentData)
        {
            _pgHostelRentData = pgHostelRentData;
        }

        [HttpGet("get_all_PgHostelRentData")]
        public IActionResult GetPgHostelRents()
        {
            return Ok(_pgHostelRentData.GetPgHostelRents());
        }

        [HttpGet("get_PgHostelRentData/{id}")]
        public IActionResult GetPgHostelRent(int id)
        {
            var data = _pgHostelRentData.GetPgHostelRent(id);
            if (data != null)
            {
                return Ok(_pgHostelRentData.GetPgHostelRent(id));
            }

            return NotFound($"PgHostelRentData with Id-{id} was Not Found.");
        }

        [HttpPost("add_PgHostelRentData")]
        public IActionResult GetPgHostelRent(Pg_Hostel_Rent pgHostelRent)
        {

            _pgHostelRentData.AddPgHostelRent(pgHostelRent);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, pgHostelRent);
        }

        [HttpDelete("delete_PgHostelRentData/{id}")]
        public IActionResult DeletePgHostelRent(int id)
        {
            var data = _pgHostelRentData.GetPgHostelRent(id);
            if (data != null)
            {
                _pgHostelRentData.DeletePgHostelRent(data);
                return Ok();
            }

            return NotFound($"PgHostelRentData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_PgHostelRentData/{id}")]
        public IActionResult EditPgHostelRent(int id, Pg_Hostel_Rent pgHostelRent)
        {
            var existingPgHostelRentData = _pgHostelRentData.GetPgHostelRent(id);
            if (existingPgHostelRentData != null)
            {
                pgHostelRent.Pg_Hostel_Rent_Id = existingPgHostelRentData.Pg_Hostel_Rent_Id;
                _pgHostelRentData.EditPgHostelRent(pgHostelRent);

            }
            return Ok(pgHostelRent);

        }
    }
}
