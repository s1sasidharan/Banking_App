using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;
using Yosotronics.Persistence.Repositories;

namespace Yesotronics.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Response PostCustomer(Customer customer)
        {
            return _customerRepository.PostCustomer(customer);
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers = _customerRepository.GetCustomers();
            return customers;
        }
    }

}
