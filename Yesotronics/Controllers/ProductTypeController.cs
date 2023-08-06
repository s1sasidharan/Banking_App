using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypeController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpPost]
        public IActionResult PostProductType(ProductTypeRequest request)
        {
            Response response;
            response = _productTypeService.PostProductType(request);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetProductTypes()
        {
            List<ProductType> response = new List<ProductType>();
            response = _productTypeService.GetProductTypes();
            return Ok(response);
        }

    }
}
