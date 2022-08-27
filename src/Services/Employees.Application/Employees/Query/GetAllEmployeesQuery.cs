using Employees.Application.Common.Interfaces;
using Employees.Application.Common.Mapper;
using MediatR;

namespace Employees.Application.Employees.Query
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeDto>>
    {
    }

    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, List<EmployeeDto>>
    {
        private readonly IEmployeeQueryRepository _employeeQueryRepository;

        public GetAllEmployeesQueryHandler(IEmployeeQueryRepository employeeQueryRepository)
        {
            _employeeQueryRepository = employeeQueryRepository;
        }

        public async Task<List<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeQueryRepository.GetAllAsync();
            var response = CustomerMapper.Mapper.Map<List<EmployeeDto>>(employees);
            return response;
        }
    }
}
