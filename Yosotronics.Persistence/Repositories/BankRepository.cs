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
    public  class BankRepository : IBankRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public BankRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Bank> GetBanks()
        {
            List<Bank> banks = new List<Bank>();
            List<BankDTO> banksDTO = new List<BankDTO>();
            banksDTO = _context.Banks.ToList();
            banks = _mapper.Map<List<Bank>>(banksDTO);
            return banks;
        }
            public Response PostBank(Bank bank)
        {
            Response response = new Response();

            BankDTO bankDTO = new BankDTO();
            bankDTO = _mapper.Map<BankDTO>(bank);
            bankDTO.CreatedBy = 1;
            bankDTO.CreatedDate = DateTime.Now;
            bankDTO.IsActive = true;
            bankDTO.IsDeleted = false;

            _context.Banks.Add(bankDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
