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
using Yosotronics.Persistence.Repositories;

namespace Yesotronics.Service.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public Response PostSubCategory(SubCategoryRequest subCategoryRequest)
        {
            return _subCategoryRepository.PostSubCategory(subCategoryRequest);
        }
        public List<SubCategory> GetSubCategories()
        {
            return _subCategoryRepository.GetSubCategories();
        }
    }
}
