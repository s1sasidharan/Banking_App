using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence
{
    public class YosotronicsDbContext : DbContext
    {
        public YosotronicsDbContext(DbContextOptions<YosotronicsDbContext> options) : base(options) { }

        public DbSet<BankDTO> Banks { get; set; }
        public DbSet<BranchDTO> Branches { get; set; }
        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<TransactionDTO> Transactions { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("bank");

        }
    }
}
