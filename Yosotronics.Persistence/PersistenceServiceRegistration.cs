using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Repositories;

namespace Yosotronics.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            return services;
        }
       
    }
}
