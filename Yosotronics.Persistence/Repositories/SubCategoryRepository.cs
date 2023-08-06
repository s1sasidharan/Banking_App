using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.Repositories
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public SubCategoryRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<SubCategory> GetSubCategories()
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            List<SubCategoryDTO> subCategoriesDTO = new List<SubCategoryDTO>();
            subCategoriesDTO = _context.SubCategories.ToList();
            subCategories = _mapper.Map<List<SubCategory>>(subCategoriesDTO);
            return subCategories;
        }
        public Response PostSubCategory(SubCategoryRequest subCategoryRequest)
        {
            Response response = new Response();

            SubCategoryDTO subCategoryDTO = new SubCategoryDTO();
            subCategoryDTO = _mapper.Map<SubCategoryDTO>(subCategoryRequest); ;
            subCategoryDTO.CreatedBy = 1;
            subCategoryDTO.CreatedDate = DateTime.Now;
            subCategoryDTO.IsActive = true;
            subCategoryDTO.IsDeleted = false;

            _context.SubCategories.Add(subCategoryDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
