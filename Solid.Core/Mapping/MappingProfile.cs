using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Books_on_loan, BookOnLoanDto > ().ReverseMap();
            CreateMap<Lend, LendDto>().ReverseMap().ReverseMap();
            CreateMap<Writer, WriterDto>().ReverseMap();
        }
    }
}
