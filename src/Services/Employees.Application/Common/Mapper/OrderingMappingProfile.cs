using AutoMapper;
using Employees.Application.Employees.Query;
using Employees.Domain.Entities;

namespace Employees.Application.Common.Mapper
{
    public class OrderingMappingProfile : Profile
    {
        public OrderingMappingProfile()
        {
            CreateMap<Employee, EmployeeResponse>().ReverseMap();
            //CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            //CreateMap<Customer, EditCustomerCommand>().ReverseMap();
        }
    }
}
