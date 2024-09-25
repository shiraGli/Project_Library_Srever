using AutoMapper;
using Library.Entities;
using Solid.Core.Entities;

namespace Library.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<AccountPostModel, Account>();
            CreateMap<CustomerPostModel, Customer>();
            CreateMap<BookOnLoanPostModel, Books_on_loan>();
            CreateMap<BookPostModel, Book>();
            CreateMap<LendPostModel, Lend>();
            CreateMap<WriterPostModel, Writer>();
        }
     
    }
}
