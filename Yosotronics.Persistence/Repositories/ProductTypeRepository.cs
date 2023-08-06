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
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public ProductTypeRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<ProductType> GetProductTypes()
        {
            List<ProductType> productTypes = new List<ProductType>();
            List<ProductTypeDTO> productTypesDTO = new List<ProductTypeDTO>();
            productTypesDTO = _context.ProductTypes.ToList();
            productTypes = _mapper.Map<List<ProductType>>(productTypesDTO);
            return productTypes;
        }
        public Response PostProductType(ProductTypeRequest productTypeRequest)
        {
            Response response = new Response();

            ProductTypeDTO protectTypeDTO = new ProductTypeDTO();
            protectTypeDTO = _mapper.Map<ProductTypeDTO>(productTypeRequest);
            protectTypeDTO.CreatedBy = 1;
            protectTypeDTO.CreatedDate = DateTime.Now;
            protectTypeDTO.IsActive = true;
            protectTypeDTO.IsDeleted = false;

            _context.ProductTypes.Add(protectTypeDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
