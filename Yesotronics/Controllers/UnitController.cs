using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models;
using Yesotronics.Service.IServices;
using Yesotronics.Domain.Models.Response;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : Controller
    {
        private readonly IUnitService _unitService;
        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpPost]
        public IActionResult PostUnit(UnitRequest request)
        {
            Response response;
            response = _unitService.PostUnit(request);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetUnits()
        {
            List<Unit> response = new List<Unit>();
            response = _unitService.GetUnits();
            return Ok(response);
        }
    }
}
