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
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Response PostTransaction(Transaction transaction)
        {
            return _transactionRepository.PostTransaction(transaction);
        }
        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            transactions = _transactionRepository.GetTransactions();
            return transactions;
        }
    }

}
