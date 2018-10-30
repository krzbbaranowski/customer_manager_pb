using AutoMapper;
using CustomerManager.Core.DTO;
using CustomerManager.Core.PO;

namespace CustomerManager.Core.Infrastructure.MapperProfiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDTO, CustomerListItemPO>();
        }
    }
}