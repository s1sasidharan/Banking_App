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
            services.AddTransient<IBankService, BankService>();
            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ITransactionService, TransactionService>();
            return services;
        }
    }
}
