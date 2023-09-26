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
    public  class TransactionRepository : ITransactionRepository
    {
        private readonly YosotronicsDbContext _context;
        private readonly IMapper _mapper;

        public TransactionRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            List<TransactionDTO> transactionDTO = new List<TransactionDTO>();
            transactionDTO = _context.Transactions.ToList();
            transactions = _mapper.Map<List<Transaction>>(transactionDTO);
            return transactions;
        }
            public Response PostTransaction(Transaction transaction)
        {
            Response response = new Response();

            decimal dayLimit = _context.Transactions.Where(x => x.CustomerId == transaction.CustomerId && x.TransactionDate.Date == DateTime.Now.Date).Sum(x => x.Amount);

            if(dayLimit < 100000) { 
            TransactionDTO transactionDTO = new TransactionDTO();
            transactionDTO = _mapper.Map<TransactionDTO>(transaction);
            transactionDTO.CreatedBy = 1;
            transactionDTO.CreatedDate = DateTime.Now;
            transactionDTO.IsActive = true;
            transactionDTO.IsDeleted = false;

            _context.Transactions.Add(transactionDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            }
            else
            {
                response.Status = "Failed";
                response.Message = "Daily usage limit (100000) exceeded";

            }
            return response;

        }
    }
}
