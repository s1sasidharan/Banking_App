using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore;
using Yesotronics.Domain.Models;
using Yosotronics.Persistence.Models;

namespace Yesotronics.Service.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Bank, BankDTO>().ReverseMap();
            CreateMap<Branch, BranchDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Transaction, TransactionDTO>().ReverseMap();

        }
        
        
    }
}
