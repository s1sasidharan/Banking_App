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
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpPost]
        public IActionResult PostTransaction(Transaction transaction)
        {
            Response response;
            response = _transactionService.PostTransaction(transaction);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetTransactions()
        {
            List<Transaction> response = new List<Transaction>();
            response = _transactionService.GetTransactions();
            return Ok(response);
        }
    }
}
