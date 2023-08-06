using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Request;
using Yosotronics.Persistence.Models;

namespace Yesotronics.Service.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<BrandRequest, BrandDTO>().ReverseMap();
            CreateMap<Brand, BrandDTO>().ReverseMap();
            CreateMap<Unit, UnitDTO>().ReverseMap();
            CreateMap<UnitRequest, UnitDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<CategoryRequest, CategoryDTO>().ReverseMap();
            CreateMap<SubCategory, SubCategoryDTO>().ReverseMap();
            CreateMap<SubCategoryRequest, SubCategoryDTO>().ReverseMap();
            CreateMap<ProductType, ProductTypeDTO>().ReverseMap();
            CreateMap<ProductTypeRequest, ProductTypeDTO>().ReverseMap();

        }
        
        
    }
}
