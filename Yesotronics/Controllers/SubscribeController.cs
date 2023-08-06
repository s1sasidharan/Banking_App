using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _subscribeService;
        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpPost]
        public IActionResult PostSubscribe(SubscribeRequest request)
        {
            Response response;
            response = _subscribeService.PostSubscribe(request);
            return Ok(response);
        }
    }
}
