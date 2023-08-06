using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService; 

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult PostUser(UserRequest request)
        {
            Response response;
            response = _userService.PostUser(request);
            return Ok(response);
        }
    }
}
