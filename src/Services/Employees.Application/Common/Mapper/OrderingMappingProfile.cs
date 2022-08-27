using AutoMapper;
using Employees.Application.Employees.Commands.CreateEmployee;
using Employees.Application.Employees.Query;
using Employees.Domain.Entities;

namespace Employees.Application.Common.Mapper
{
    public class OrderingMappingProfile : Profile
    {
        public OrderingMappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
            //CreateMap<Customer, EditCustomerCommand>().ReverseMap();
        }
    }
}
