using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;

namespace Yesotronics.Service
{
    public static class DomainServiceRegistration
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services) {
            services.AddTransient<IUserService,UserService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ISubCategoryService, SubCategoryService>();
            services.AddTransient<ISubscribeService, SubscribeService>();
            services.AddTransient<IAttributeService, AttributeService>();
            services.AddTransient<IProductTypeService, ProductTypeService>();
            return services;
        }
    }
}
