using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serverside_Project_API.Model;
using Serverside_Project_API.Post_Ad_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostAdController : ControllerBase
    {
        private IPostAdData _postAdData;
        public PostAdController(IPostAdData postAdData)
        {
            _postAdData = postAdData;
        }

        [HttpGet("get_all_PostAdData")]
        public IActionResult GetPostAds()
        {
            return Ok(_postAdData.GetPostAds());
        }

        [HttpGet("get_PostAdData/{id}")]
        public IActionResult GetPostAd(int id)
        {
            var data = _postAdData.GetPostAd(id);
            if (data != null)
            {
                return Ok(_postAdData.GetPostAd(id));
            }

            return NotFound($"PostAdData with Id-{id} was Not Found.");
        }

        [HttpPost("add_PostAdData")]
        public IActionResult GetPostAd(Post_Ad postAd)
        {

            _postAdData.AddPostAd(postAd);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path, postAd);
        }

        [HttpDelete("delete_PostAdData/{id}")]
        public IActionResult DeletePostAd(int id)
        {
            var data = _postAdData.GetPostAd(id);
            if (data != null)
            {
                _postAdData.DeletePostAd(data);
                return Ok();
            }

            return NotFound($"PostAdData with Id-{id} was Not Found.");
        }

        [HttpPatch("update_PostAdData/{id}")]
        public IActionResult EditPostAd(int id, Post_Ad postAd)
        {
            var existingPostAdData = _postAdData.GetPostAd(id);
            if (existingPostAdData != null)
            {
                postAd.Post_Id = existingPostAdData.Post_Id;
                _postAdData.EditPostAd(postAd);

            }
            return Ok(postAd);

        }
    }
}
