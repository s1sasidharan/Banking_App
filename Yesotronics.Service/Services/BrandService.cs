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
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Response PostBrand(BrandRequest brandRequest)
        {
            return _brandRepository.PostBrand(brandRequest);
        }
        public List<Brand> GetBrands()
        {
            return _brandRepository.GetBrands();
        }
    }
}
