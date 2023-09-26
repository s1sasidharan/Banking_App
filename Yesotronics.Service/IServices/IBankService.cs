using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.Services;
using Yosotronics.Persistence.Models;

namespace Yesotronics.Service.IServices
{
    public interface IBankService
    {
        public Response PostBank(Bank bank);
        public List<Bank> GetBanks();
    }
}
