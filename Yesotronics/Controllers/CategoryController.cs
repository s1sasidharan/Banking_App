using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;
using Yosotronics.Persistence.Models;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult PostCategory(CategoryRequest request)
        {
            Response response;
            response = _categoryService.PostCategory(request);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            List<Category> response = new List<Category>();
            response = _categoryService.GetCategories();
            return Ok(response);
        }
    }
}
