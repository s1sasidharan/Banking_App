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
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;
        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public Response PostBank(Bank bank)
        {
            return _bankRepository.PostBank(bank);
        }
        public List<Bank> GetBanks()
        {
            List<Bank> banks = new List<Bank>();
            banks = _bankRepository.GetBanks();
            return banks;
        }
    }

}
