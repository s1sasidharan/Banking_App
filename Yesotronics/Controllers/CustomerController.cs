using Microsoft.AspNetCore.Mvc;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;
using Yosotronics.Persistence.Models;

namespace Yesotronics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public IActionResult PostCustomer(Customer customer)
        {
            Response response;
            response = _customerService.PostCustomer(customer);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetCustomers()
        {
            List<Customer> response = new List<Customer>();
            response = _customerService.GetCustomers();
            return Ok(response);
        }
    }
}
