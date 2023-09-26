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
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }
        [HttpPost]
        public IActionResult PostBranch(Branch branch)
        {
            Response response;
            response = _branchService.PostBranch(branch);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetBranches()
        {
            List<Branch> response = new List<Branch>();
            response = _branchService.GetBranches();
            return Ok(response);
        }
    }
}
