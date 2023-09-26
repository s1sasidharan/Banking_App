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
    public class BankController : Controller
    {
        private readonly IBankService _bankService;
        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }
        [HttpPost]
        public IActionResult PostBank(Bank bank)
        {
            Response response;
            response = _bankService.PostBank(bank);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetBrands()
        {
            List<Bank> response = new List<Bank>();
            response = _bankService.GetBanks();
            return Ok(response);
        }
    }
}
