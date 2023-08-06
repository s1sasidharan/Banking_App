using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yesotronics.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Response PostCategory(CategoryRequest categoryRequest)
        {
            return _categoryRepository.PostCategory(categoryRequest);
        }
        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
