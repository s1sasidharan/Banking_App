using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;

namespace Yesotronics.Service.IServices
{
    public interface IProductTypeService
    {
        public Response PostProductType(ProductTypeRequest productTypeRequest);
        public List<ProductType> GetProductTypes();
    }
}
