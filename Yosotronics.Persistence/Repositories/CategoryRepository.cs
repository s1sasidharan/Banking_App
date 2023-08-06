using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMapper _mapper;
        private readonly YosotronicsDbContext _context;

        public CategoryRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;    
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            List<CategoryDTO> categoriesDTO = new List<CategoryDTO>();
            categoriesDTO = _context.Categories.ToList();
            categories = _mapper.Map<List<Category>>(categoriesDTO);
            return categories;
        }

        public Response PostCategory(CategoryRequest categoryRequest)
        {
            Response response = new Response();

            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO = _mapper.Map<CategoryDTO>(categoryRequest);
            categoryDTO.CreatedBy = 1;
            categoryDTO.CreatedDate = DateTime.Now;
            categoryDTO.IsActive = true;
            categoryDTO.IsDeleted = false;

            _context.Categories.Add(categoryDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }

    }
}
