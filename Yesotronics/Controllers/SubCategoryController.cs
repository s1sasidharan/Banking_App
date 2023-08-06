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
    public class SubCategoryController : Controller
    {
        
            private readonly ISubCategoryService _subCategoryService;
        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpPost]
        public IActionResult PostSubCategory(SubCategoryRequest request)
        {
            Response response;
            response = _subCategoryService.PostSubCategory(request);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetSubCategories()
        {
            List<SubCategory> response = new List<SubCategory>();
            response = _subCategoryService.GetSubCategories();
            return Ok(response);
        }

    }
}
