using Aurora.User.Data;
using Aurora.User.Models;
using Aurora.User.Models.User;
using Aurora.User.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aurora.User.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserAPIController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("GetUsers")]
        public async Task<ActionResult<UserResponseModel>> GetUsers(CommonPaginationModel model)
        {
            var users = await _userService.GetUsersAsync(model);
            return Ok(users);
        }
    }
}
