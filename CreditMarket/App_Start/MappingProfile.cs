using AutoMapper;
using CreditMarket.Dtos;
using CreditMarket.Models;

namespace CreditMarket.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Loan, LoanDto>();
            Mapper.CreateMap<Order, OrderDto>();

            // Dto to Domain
            Mapper.CreateMap<LoanDto, Loan>().ForMember(l => l.Id, opt => opt.Ignore());
            Mapper.CreateMap<OrderDto, Order>().ForMember(o => o.Id, opt => opt.Ignore());
        }
    }
}