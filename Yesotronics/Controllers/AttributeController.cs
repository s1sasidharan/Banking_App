using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : Controller
    {
        private readonly IAttributeService _attributeService;
        public AttributeController(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }

        [HttpPost]
        public IActionResult PostAttribute(AttributeRequest request)
        {
             Response response;
            response = _attributeService.PostAttribute(request);
            return Ok(response);
        }
    }
}
