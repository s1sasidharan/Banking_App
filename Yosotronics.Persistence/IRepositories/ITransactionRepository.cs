using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.IRepositories
{
    public interface ITransactionRepository
    {
        public Response PostTransaction(Transaction transaction);
        public List<Transaction> GetTransactions();
    }
}
