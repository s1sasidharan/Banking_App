using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.Repositories
{
    public  class CustomerRepository : ICustomerRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            List<CustomerDTO> customerDTO = new List<CustomerDTO>();
            customerDTO = _context.Customers.ToList();
            customers = _mapper.Map<List<Customer>>(customerDTO);
            return customers;
        }
            public Response PostCustomer(Customer customer)
        {
            Response response = new Response();

            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO = _mapper.Map<CustomerDTO>(customer);
            customerDTO.CreatedBy = 1;
            customerDTO.CreatedDate = DateTime.Now;
            customerDTO.IsActive = true;
            customerDTO.IsDeleted = false;

            _context.Customers.Add(customerDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
