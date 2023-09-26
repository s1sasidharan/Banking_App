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
    public  class BranchRepository : IBranchRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public BranchRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Branch> GetBranches()
        {
            List<Branch> branches = new List<Branch>();
            List<BranchDTO> branchDTO = new List<BranchDTO>();
            branchDTO = _context.Branches.ToList();
            branches = _mapper.Map<List<Branch>>(branchDTO);
            return branches;
        }
            public Response PostBranch(Branch branch)
        {
            Response response = new Response();

            BranchDTO branchDTO = new BranchDTO();
            branchDTO = _mapper.Map<BranchDTO>(branch);
            branchDTO.CreatedBy = 1;
            branchDTO.CreatedDate = DateTime.Now;
            branchDTO.IsActive = true;
            branchDTO.IsDeleted = false;

            _context.Branches.Add(branchDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
