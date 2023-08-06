using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Repositories;

namespace Yesotronics.Service.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeRepository _productTypeRepository;
        public ProductTypeService(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }
        public Response PostProductType(ProductTypeRequest productTypeRequest)
        {
            return _productTypeRepository.PostProductType(productTypeRequest);
        }
        public List<ProductType> GetProductTypes()
        {
            return _productTypeRepository.GetProductTypes();
        }
    }
}
