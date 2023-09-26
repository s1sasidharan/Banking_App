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
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;
        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public Response PostBranch(Branch branch)
        {
            return _branchRepository.PostBranch(branch);
        }
        public List<Branch> GetBranches()
        {
            List<Branch> branches = new List<Branch>();
            branches = _branchRepository.GetBranches();
            return branches;
        }
    }

}
