using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aurora.User.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/userv")]
    public class UserVersionAPiController : ControllerBase
    {
        [HttpGet("GetUser")]
        [MapToApiVersion("1.0")]
        public IActionResult GetV1()
        {
            return Ok("This is API version 1.0");
        }

        [HttpGet("GetUser")]
        [MapToApiVersion("2.0")]
        public IActionResult GetV2()
        {
            return Ok("This is API version 2.0");
        }
        [HttpGet("common")]
        [ApiVersionNeutral]
        public IActionResult GetCommon()
        {
            return Ok("This is a common action without versioning");
        }
    }
}
