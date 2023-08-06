using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpPost]
        public IActionResult PostBrand(BrandRequest request)
        {
            Response response;
            response = _brandService.PostBrand(request);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetBrands()
        {
            List<Brand> response = new List<Brand>();
            response = _brandService.GetBrands();
            return Ok(response);
        }
    }
}
