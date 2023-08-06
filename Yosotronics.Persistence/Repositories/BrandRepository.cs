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
    public  class BrandRepository : IBrandRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public BrandRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();
            List<BrandDTO> brandsDTO = new List<BrandDTO>();
            brandsDTO = _context.Brands.ToList();
            brands = _mapper.Map<List<Brand>>(brandsDTO);
            return brands;
        }
            public Response PostBrand(BrandRequest brandRequest)
        {
            Response response = new Response();

            BrandDTO brandDTO = new BrandDTO();
            brandDTO = _mapper.Map<BrandDTO>(brandRequest);
            brandDTO.CreatedBy = 1;
            brandDTO.CreatedDate = DateTime.Now;
            brandDTO.IsActive = true;
            brandDTO.IsDeleted = false;

            _context.Brands.Add(brandDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
